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

int getForceSensor()
{
  return analogRead(ForceSensor);
}

void moveMotor(int direction, int distance)
{
  // Move motor a fixed distance (time)
  // possibly change this to include calibration data
  digitalWrite(MotorDir, direction);
  digitalWrite(MotornSleep, HIGH);
  delay(10);
  digitalWrite(MotorEn, HIGH);
  delay(distance);
  digitalWrite(MotorEn, LOW);
}
void startMotorMove(int direction)
{
  // This is so we can start moving the motor and do other stuff like listen for latency responses
  digitalWrite(MotorDir, direction);
}

void endMotorMove()
{
  digitalWrite(MotorEn, LOW);
}

void calibrationTest()
{
  startMotorMove(OUT);
  delay(10);
  float volts = getMotorVoltage();
  float amps = getMotorAmps();

  delay(1000);

  startMotorMove(IN);
  delay(1000);
  endMotorMove();
}

float getMotorVoltage()
{
  return ina220.getBusMilliVolts(0) / 1000.0;
}

float getMotorAmps()
{
  return ina220.getBusMicroAmps(0) / 1000.0;
}

bool findBitePoint()
{
  // Move motor 1mm steps until force gauge starts reading
  // retract in 0.1mm steps until force gauge stops reading

  // if you need to move more than idk 5mm quit out with error
  int lastForce = 0;
  for (int i = 0; i < 5; i++)
  {
    int force = getForceSensor();
    if (lastForce > force)
    {

    }
    else
    {
      moveMotor(OUT, 100);
    }

  }
  return true;
}

void runSwitchActuationTest()
{
  Serial.setTimeout(3000);
  findBitPoint();
  Serial.println("Act Tool Ready");
  

  while (input[0] != 'X') {
    getSerialChars();
    //input[0] = '0';
    //Serial.println(InterruptCount); //debugging use only
    
    if (input[0] == 'N') {
      moveMotor(OUT, 1);
      getClickChar(); // removed while as getclickchar acts as 1s timer + returns when new line received

    }

  }
  Serial.setTimeout(100);
  Serial.println("Clicks Finished");
  toggleLED(true);
}

void runSwitchForceTest()
{
  // move motor in 0.1mm? steps and take force reading
  findBitePoint();
  Serial.println("Force Tool Ready");

}

void runSwitchLatencyTest()
{
  findBitePoint();
  Serial.println("Latency Tool Ready");

}

void runMouseSwitchTest()
{
  findBitePoint();
  Serial.println("MSwitch Tool Ready");

}

void runMouseSensorTest()
{
  // We have to assume mouse is pressed against the sensor for this test
  startMotorMove(OUT);
  long start = micros();
  getClickChar();
  long latency = micros();
  endMotorMove();
  long end = micros();
  long latencyTime = latency - start;
  long motorTime = end - start;
  Serial.print("SENSOR:");
  Serial.println(latencyTime);
  // Do something with the motor time to determine accuracy. 
}
