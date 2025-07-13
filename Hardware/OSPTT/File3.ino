void setup() {

  Serial.begin(115200);
  while (!Serial) {
    ;  // wait for serial port to connect. Needed for native USB port only
  }
  
  
  pinMode(LEDPin, OUTPUT);
  pinMode(MotorEn, OUTPUT);
  pinMode(MotornSleep, OUTPUT);
  pinMode(MotorDir, OUTPUT);
  pinMode(LEDPin, OUTPUT);
  
  Wire.begin();
  eprom.get(0, calib);
  if (calib.boardId == 0)
  {
    Serial.println("CALIB Missing");
  }  
  
  analogReadResolution(16);

  establishContact();  // send a byte to establish contact until receiver responds

  setupMotor();

  setupScale();

}

void loop() {
  getSerialChars();
  if (input[0] == 'A') // Calibration Test Mode
  {
    if (input[1] == '1') // Sweep motor with 5ms pulses (0.02mm)
    {
      int boardId = (convertHexToDec(input[2])*1000) + (convertHexToDec(input[3])*100) + (convertHexToDec(input[4])*10) + (convertHexToDec(input[5]));
      calib.boardId = boardId;
      calib.hallData[0] = getHESensor(1000);
      for (int i = 0; i < 500; i++)
      {
        moveMotor(OUT, 6);
        delay(500);
        calib.hallData[i + 1] = getHESensor(10000);
        delay(100);
      }
      // save to eeprom
      eprom.put(0, calib);
    }
    else
    {
      int oneMill = 100;
      int pointOneMill = 10;
      moveMotor(OUT, oneMill);
      Serial.println("Enter actual measurement");
      while (input[0] != 'X')
      {
        getSerialChars();
        if (input[0] == 'C')
        {
          int calBit1 = (convertHexToDec(input[1]));
          int calBit2 = (convertHexToDec(input[2]));

        }
      }
    }
  }
  else if (input[0] == 'C') // Set Calibration Data
  {
    // Setting Board ID and calibration Data
    int boardId = (convertHexToDec(input[1])*1000) + (convertHexToDec(input[2])*100) + (convertHexToDec(input[3])*10) + (convertHexToDec(input[4]));
    calib.boardId = boardId;
    int calBit1 = (convertHexToDec(input[5]));
    int calBit2 = (convertHexToDec(input[6]));

    calibrationTest();
    //calib.oneMill = (calBit1 * 10) + calBit2;
    int calBit3 = (convertHexToDec(input[7]));
    int calBit4 = (convertHexToDec(input[8]));


    //calib.pointOneMill = (calBit3 * 10) + calBit4;
    
    eprom.put(0, calib);
  }
  else if (input[0] == 'I')
  {
    Serial.print("FW:");
    Serial.println(firmwareVersion);
    Serial.print("CALIB:");
    Serial.print(calib.boardId);
  }
  else if (input[0] == 'T')
  {
    if (calib.boardId == 0) // Check the board calibration data is available.
    {
      Serial.println("TEST CANCELLED - NO CALIBRATION DATA");
    }
    else
    {
      if (input[1] == '1') // Switch Actuation Test
      {
        runSwitchActuationTest();
      }
      else if (input[1] == '2') // Switch Force Test
      {
        runSwitchForceTest();
      }
      else if (input[1] == '3') // Switch latency test
      {
        int msb = convertHexToDec(input[2]) * 100;
        int lsb = convertHexToDec(input[3] * 10);
        runSwitchLatencyTest(msb + lsb);
      }
      else if (input[1] == '4') // Mouse Switch Tests
      {
        int msb = convertHexToDec(input[2]) * 100;
        int lsb = convertHexToDec(input[3] * 10);
        runMouseSwitchTest(msb + lsb);
      }
      else if (input[1] == '5') // Mouse Sensor Tests
      {
        runMouseSensorTest();
      }
    }
  }
  else if (input[0] == 'Z')
  {
    //calibrationTest();
    if (input[1] == 'Z')
    {
      moveMotor(IN, 3000);
    }
    else if (input[1] == 'X')
    {
      Serial.println();
    }
    else if (input[1] == 'S')
    {
      Serial.print(getHESensor(1000));
      Serial.print(",");
    }
    else 
    {
      int msb = convertHexToDec(input[1]);
      int midsb = convertHexToDec(input[2]);
      int lsb = convertHexToDec(input[3]);
          
      Serial.print(getHESensor(1000));
      Serial.print(",");
      moveMotor(OUT, (msb * 100) + (midsb * 10) + lsb);
      delay(100);
    }
  }
  else if (input[0] == 'W')
  {
    int msb = convertHexToDec(input[1]);
    int midsb = convertHexToDec(input[2]);
    int lsb = convertHexToDec(input[3]);
    Serial.print((msb * 100) + (midsb * 10) + lsb);
    Serial.print(",");
    Serial.print(getHESensor());
    Serial.println();
    long t1 = micros();
    int val = getHESensor(100);
    long t2 = micros();
    Serial.println(t2 - t1);

  }
  else if (input[0] == 'V')
  {
    //calibrationTest();
    if (input[1] == 'V')
    {
      moveMotor(IN, 3000);
    }
    else if (input[1] == 'X')
    {
      Serial.println();
    }
    else 
    {
      int msb = convertHexToDec(input[1]);
      int midsb = convertHexToDec(input[2]);
      int lsb = convertHexToDec(input[3]);
      int count = convertHexToDec(input[4]);
      int count2 = convertHexToDec(input[5]);
      Serial.print(getHESensor(1000));
      Serial.print(",");
      int counts = (count * 100) + (count2 * 10);
      int distance = (msb * 100) + (midsb * 10) + lsb;
      for (int i = 0; i < counts; i++)
      {
        moveMotor(OUT, distance);
        delay(100);
        //for (int k = 0; k < 10; k++)
        //{
          Serial.print(getHESensor(10000));
          Serial.print(",");
        //}
        //Serial.println();
        delay(3000); // give me time to write caliper measurement



      }
      Serial.println();
    }
  }


}
