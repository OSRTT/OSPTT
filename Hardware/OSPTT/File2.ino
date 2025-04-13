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
   return 0;
}

void moveMotor(bool direction, int distance)
{
  if (direction)
  {
    digitalWrite(MotorDir, HIGH);

  }
  else
  {
    digitalWrite(MotorDir, LOW);

  }

}

float getMotorVoltage()
{
  return ina220.getBusMilliVolts(0) / 1000.0;
}

float getMotorAmps()
{
  return ina220.getBusMicroAmps(0) / 1000.0;
}

void runSwitchActuationTest()
{
  Serial.setTimeout(3000);
  Serial.println("Actuation Point Test Started");
  

  while (input[0] != 'X') {
    getSerialChars();
    //input[0] = '0';
    //Serial.println(InterruptCount); //debugging use only
    
    if (!digitalRead(PullUpPin)) {
      //input[0] = '0';
      
      long start = micros();
      //while (input[0] != 'H' && input[0] != 'X') {
        getClickChar(); // removed while as getclickchar acts as 1s timer + returns when new line received
      //}
      long end = micros();
      long time = end - start;
      

      Serial.print("CLICK:");
      Serial.println(time);
      toggleLED(true);
      delay(200);
      // sync clocks again
      toggleLED(false);

      delay(100);
      input[0] = ' ';
      if (sourceType == 7)
      {
        while (input[0] != 'R')
        {
          getClickChar();
        }
        toggleLED(true);
        delay(200);
        toggleLED(false);
      }
      // Serial.print("PDIF:");
      // Serial.println(PullDownInterruptFlag);
    }
  }
  Serial.setTimeout(100);
  Serial.println("Clicks Finished");
  toggleLED(true);
}

void runSwitchForceTest()
{

}

void runSwitchLatencyTest()
{

}

void runMouseSwitchTest()
{

}

void runMouseSensorTest()
{
  
}
