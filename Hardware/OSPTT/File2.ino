void getSerialChars() {
  for (int i = 0; i < INPUT_SIZE + 1; i++) {
    input[i] = ' ';
  }
  byte size = Serial.readBytes(input, INPUT_SIZE);
  input[size] = 0;
}

void getClickChar() {
  for (int i = 0; i < INPUT_SIZE + 1; i++) {
    input[i] = '0';
  }
  byte size = Serial.readBytesUntil('\n', input, 1);
  input[size] = 0;
}

int convertHexToDec(char c) {
  if (c <= 57) {
    return c - '0';  // Convert char to int
  } else {
    return c - 55;
  }
}

void establishContact() {
  while (Serial.available() <= 0) {
    Serial.println("OSPTT");
    delay(250);
  }
}

void toggleLED(bool state) {
  if (state) {
    analogWrite(3, 0xFF);
  } else {
    analogWrite(3, 0x00);
  }
}

int getADCValue(int count, int pin = 0) {
  uint32_t value = 0;
  int localCounter = 0;
  while (localCounter < count) {

    value += analogRead(pin);
    localCounter++;
  }
  value /= count;
  return value;
}

long fillADCBuffer(int count, int pin = 0) {

  int localCounter = 0;
  long startTimer = micros();
  while (localCounter < count) {
    adcBuff[localCounter] = analogRead(pin);
    localCounter++;
  }
  long endTimer = micros();
  return endTimer - startTimer;
}

int getSingleADCValue(int pin = 0) {
  return analogRead(pin);
}

int getHESensor(int samples = 10)
{
  long average = 0;
  for (int i = 0; i < samples; i++)
  {
    int sample = analogRead(HESensor);
    average += ( sample - average ) / ( i + 1);
  }
  return average;
}

float getMotorPosition(int position)
{
  int arrSize = sizeof(calib.hallData) / sizeof(int);
  for (int i = 1; i < arrSize; i++)
  {
    if (calib.hallData[i] <= position && calib.hallData[i - 1] > position)
    {
      int topEnd = calib.hallData[i - 1] - position;
      int difference = calib.hallData[i - 1] - calib.hallData[i];
      float fraction = difference / topEnd;
      float result = 0.02 * fraction;
      result = roundf(result * 100) / 100;

      return (i * 0.02) + result; // find closest measured value then interpolate intermediate value to 2dp; 
    }
  }
  return 0;
}

float getLoadCell(int samples = 5)
{
  return scale.get_units(samples);
}

void moveMotor(int direction, int distance)
{
  // Move motor a fixed distance (time)
  // possibly change this to include calibration data
  int startPos = getHESensor(10000);
  digitalWrite(MotorDir, direction);
  digitalWrite(MotorEn, HIGH);
  delay(100);
  digitalWrite(MotornSleep, HIGH);
  delay(distance);
  digitalWrite(MotornSleep, LOW);
  digitalWrite(MotorEn, LOW);
  int endPos = getHESensor(10000);
}
void startMotorMove(int direction)
{
  // This is so we can start moving the motor and do other stuff like listen for latency responses
  digitalWrite(MotorDir, direction);
  digitalWrite(MotorEn, HIGH);
  digitalWrite(MotornSleep, HIGH);
}

void endMotorMove()
{
  digitalWrite(MotornSleep, LOW);
  digitalWrite(MotorEn, LOW);
}

void calibrationTest() // This needs to be run in free air with at least 1cm of space
{
  int arrSize = sizeof(calib.hallData) / sizeof(int);
  calib.hallData[0] = getLoadCell(1000);
  for (int i = 1; i < arrSize; i++)
  {
    moveMotor(OUT, PointZeroTwo);
    delay(100);
    calib.hallData[i] = getLoadCell(1000);
  }  
}

void setupMotor()
{
  startMotorMove(OUT);
  delay(500);
  
  startMotorMove(IN);
  delay(1000);
  endMotorMove();
}

void setupScale()
{
  scale.begin(HXData, HXClock);
  int scaleFactor = 17050;
  if (calib.ScaleCalib != 0)
  {
    scaleFactor = calib.ScaleCalib;
  }
  scale.set_scale(scaleFactor);
  scale.tare();
}

float findBitePoint()
{
  // Move motor 1mm steps until force gauge starts reading
  // retract in 0.1mm steps until force gauge stops reading

  // if you need to move more than idk 5mm quit out with error
  int lastForce = 100;
  startMotorMove(IN);
  delay(1000);
  endMotorMove();
  delay(100);
  scale.tare();
  for (int i = 0; i < 50; i++)
  {
    int force = getLoadCell();
    if (force > 5 && force < 10) // check this out with the tool built
    {
      return getMotorPosition(getHESensor());
    }
    else if (force >= 10)
    {
      moveMotor(IN, PointFive);
    }
    else
    {
      moveMotor(OUT, PointZeroFive);
    }
    delay(100);
  }
  return 0;
}

bool moveMotorNearActPoint(int actPoint)
{
  int currentPos = getHESensor(1000);
  int counter = 0;
  while (currentPos <= (actPoint * 1.08) && currentPos >= (actPoint * 1.15)) // fine tune this in testing
  {
    if (currentPos < (actPoint * 1.09))
    {
      moveMotor(IN, PointZeroFive);
    }
    else if (currentPos > (actPoint * 1.14))
    {
      moveMotor(OUT, PointZeroFive);
    }
    if (currentPos < (actPoint * 1.14))
    {
      // Move the motor well past the actuation point and come back down on it
      // as the release point is often higher than the actuation point
      moveMotor(IN, PointFive); 
    }
    delay(100);
    currentPos = getHESensor(1000);
    counter++;
    if (counter > 200 || getLoadCell(100) > 100)
    {
      Serial.println("Failed to find actuation point");
      moveMotor(IN, 2000);
      return false;
    }
  }
  return true;
}

void runSwitchActuationTest()
{
  Serial.setTimeout(3000);
  float startHE = findBitePoint();
  Serial.println("Act Tool Ready");
  bool foundActPoint = false;

  while (input[0] != 'X') {
    getSerialChars();
    //input[0] = '0';
    //Serial.println(InterruptCount); //debugging use only
    
    if (input[0] == 'N') {
      int counter = 0;
      int initialHEPos = getHESensor(100);
      while(counter < 200)
      {
        moveMotor(OUT, PointZeroFive);
        getClickChar(); // removed while as getclickchar acts as 1s timer + returns when new line received
        if (input[0] == 'H')
        {
          // Actuation point found
          Serial.print("ACTUATION:");
          float newPos = getMotorPosition(getHESensor(1000))-startHE;
          Serial.println(newPos);
          foundActPoint = true;
          break;
        }
        if (getLoadCell() > 100)
        {
          if (!foundActPoint)
          {
            Serial.println("ACTUATION:0");
            Serial.println("Failed To Find Actuation Point");
          }
          break;
        }
        counter++;
        delay(100);
      }
      startHE = findBitePoint();
    }

  }
  Serial.setTimeout(100);
  Serial.println("Clicks Finished");
  toggleLED(true);
}

void printForceResult(bool inOut, float force, float distance)
{
  Serial.print("FORCE:");
  if (inOut) 
  {
    Serial.print("OUT,");
  }
  else
  {
    Serial.print("IN,");
  }
  Serial.print(force);
  Serial.print(",");
  Serial.println(distance);
}

void runSwitchForceTest()
{
  // move motor in 0.1mm? steps and take force reading
  float startHE = findBitePoint();
  if (startHE == 0)
  {
    // Unable to find bite point, exit test
  }
  Serial.println("Force Tool Ready");
  int force = 0;
  printForceResult(false, getLoadCell(100), getMotorPosition(getHESensor(1000))-startHE);
  while (force < 100 && input[0] != 'X') 
  {
    moveMotor(OUT, PointZeroFive);
    delay(100);
    float newPos = getMotorPosition(getHESensor(1000))-startHE;
    force = getLoadCell(100);
    printForceResult(false, force, newPos);
    getSerialChars();
    if (input[0] == 'H')
    { // Note how far the actuation point is for better latency testing
      Serial.print("ACTPOINT:");
      Serial.println(newPos);
    }
  }
  printForceResult(true, getLoadCell(100), getMotorPosition(getHESensor(1000))-startHE);
  while (force > 0 && input[0] != 'X') 
  {
    moveMotor(IN, PointZeroFive);
    delay(100);
    float newPos = getMotorPosition(getHESensor(1000))-startHE;
    force = getLoadCell(100);
    printForceResult(true, force, newPos);
    getSerialChars();
    if (input[0] == 'J')
    { // Note how far the actuation point is for better latency testing
      Serial.print("RELPOINT:");
      Serial.println(newPos);
    }
  }
}

void runSwitchLatencyTest(int ClickCount)
{
  float startHE = findBitePoint();
  if (startHE == 0)
  {
    // Unable to find bite point, exit test
  }
  Serial.println("Latency Tool Ready");
  float force = 0;
  int actPoint = 0;
  int endDistance = 0;
  while (force < 100 && input[0] != 'X') 
  {
    moveMotor(OUT, PointZeroFive);
    delay(100);
    force = getLoadCell(100);
    getSerialChars();
    if (input[0] == 'H')
    { // Note how far the actuation point is for better latency testing
      actPoint = getHESensor(1000);
    }
    if (force > 80)
    {
      endDistance = getHESensor(1000);
    }
  }
  
  float actPointMM = getMotorPosition(actPoint) - startHE;
  float bottomPointMM = getMotorPosition(endDistance) - startHE;
  // If the distance from the actuation point to the bottom is less than 1mm, pause to ask for user consent.
  if (bottomPointMM - actPointMM < 1.0 )
  {
    Serial.println("MIN DISTANCE LATENCY");
    while (input[0] != 'X' || input[0] != 'S')
    {
      getSerialChars();
    }
  }

  // Run latency test from just above actuation point
  for (int i = 0; i < ClickCount; i++)
  {
    if (moveMotorNearActPoint(actPoint))
    {
      Serial.setTimeout(100);
      startMotorMove(OUT);
      long start = micros();
      getClickChar();
      long end = micros();
      endMotorMove();
      
      if (input[0] == 'H')
      {
        Serial.print("LATENCY:");
        Serial.println(end - start);
      }
      else // failed to capture input in time
      {
        Serial.setTimeout(500);
        getClickChar(); // try again before failing it. Imperfect but over 100ms... meh.
        if (input[0] == 'H')
        {
          end = micros();
          Serial.print("LATENCY:");
          Serial.println(end - start);
        }
        else
        {
          Serial.println("LATENCY:999");
        } 
      } 
    }
    else
    {
      Serial.println("Failed to find actuation point");
    }
  }

  Serial.setTimeout(1000);
}

void runMouseSwitchTest(int ClickCount)
{
  float startHE = findBitePoint();
  if (startHE == 0)
  {
    // Unable to find bite point, exit test
  }
  Serial.println("MSwitch Tool Ready");
  float force = 0;
  int actPoint = 0;
  int endDistance = 0;
  printForceResult(false, getLoadCell(100), getMotorPosition(getHESensor(1000))-startHE);
  while (force < 100 && input[0] != 'X') 
  {
    moveMotor(OUT, PointZeroFive);
    delay(100);
    float newPos = getMotorPosition(getHESensor(1000))-startHE;
    force = getLoadCell(100);
    printForceResult(false, force, newPos);
    getSerialChars();
    if (input[0] == 'H')
    { // Note how far the actuation point is for better latency testing
      Serial.print("ACTPOINT:");
      Serial.println(newPos);
      actPoint = getHESensor(1000);
    }
    if (force > 80)
    {
      endDistance = getHESensor(1000);
    }
  }
  printForceResult(true, getLoadCell(100), getMotorPosition(getHESensor(1000))-startHE);
  while (force > 0 && input[0] != 'X') 
  {
    moveMotor(IN, PointZeroFive);
    delay(100);
    float newPos = getMotorPosition(getHESensor(1000))-startHE;
    force = getLoadCell(100);
    printForceResult(true, force, newPos);
    getSerialChars();
    if (input[0] == 'J')
    { // Note how far the actuation point is for better latency testing
      Serial.print("RELPOINT:");
      Serial.println(newPos);
    }
  }

  float actPointMM = getMotorPosition(actPoint) - startHE;
  float bottomPointMM = getMotorPosition(endDistance) - startHE;
  // If the distance from the actuation point to the bottom is less than 1mm, pause to ask for user consent.
  if (bottomPointMM - actPointMM < 1.0 )
  {
    Serial.println("MIN DISTANCE LATENCY");
    while (input[0] != 'X' || input[0] != 'S')
    {
      getSerialChars();
    }
  }

  // Run latency test from just above actuation point
  for (int i = 0; i < ClickCount; i++)
  {
    if (moveMotorNearActPoint(actPoint))
    {
      Serial.setTimeout(100);
      startMotorMove(OUT);
      long start = micros();
      getClickChar();
      long end = micros();
      endMotorMove();
      
      if (input[0] == 'H')
      {
        Serial.print("MCLATENCY:");
        Serial.println(end - start);
      }
      else // failed to capture input in time
      {
        Serial.setTimeout(500);
        getClickChar(); // try again before failing it. Imperfect but over 100ms... meh.
        if (input[0] == 'H')
        {
          end = micros();
          Serial.print("MCLATENCY:");
          Serial.println(end - start);
        }
        else
        {
          Serial.println("MCLATENCY:999");
        } 
      } 
    }
    else
    {
      Serial.println("Failed to find actuation point");
    }
  }

  Serial.setTimeout(1000);
}

void runMouseSensorTest()
{
  Serial.println("MSense Ready");
  // We have to assume mouse is pressed against the sensor for this test
  float startPos = getMotorPosition(getHESensor(1000));
  startMotorMove(OUT);
  long start = micros();
  getClickChar();
  long latency = micros();
  endMotorMove();
  long end = micros();
  long latencyTime = latency - start;
  long motorTime = end - start;
  Serial.print("SENSOR:");
  Serial.print(latencyTime);
  float endPos = getMotorPosition(getHESensor(1000));
  Serial.print(":");
  Serial.print(endPos - startPos);
  // Do something with the motor time to determine accuracy. 
}
