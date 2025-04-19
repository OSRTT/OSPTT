void setup() {

  Serial.begin(115200);
  while (!Serial) {
    ;  // wait for serial port to connect. Needed for native USB port only
  }
  
  
  pinMode(LEDPin, OUTPUT);
  pinMode(MotorEn, OUTPUT);
  pinMode(MotornSleep, OUTPUT);
  pinMode(LEDPin, OUTPUT);

  uint8_t ina220Devices = ina220.begin(1, 50000, INA_ADC_MODE128AVG,INA_ADC_MODE_128AVG, INA_MODE_CONTINUOUS_BOTH, {128}, 1);)
  
  calib = my_flash_store.read();
  if (calib.boardId == 0)
  {
    Serial.println("CALIB Missing");
  }  
  

  //ADC_Init();
  analogReadResolution(14);

  establishContact();  // send a byte to establish contact until receiver responds


}

void loop() {
  getSerialChars();
  if (input[0] == 'A') // Calibration Test Mode
  {
    int oneMill = 100;
    int pointOneMill = 10;
    moveMotor(OUT, oneMill);
    while (input[0] != 'X')
    {
      getSerialChars();
      if (input[0] > '0')
      {
        int calBit1 = (convertHexToDec(input[0]));
        int calBit2 = (convertHexToDec(input[1]));
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


    calib.oneMill = calBit1 + calBit2;
  }
  else if (input[0] == 'T')
  {
    if (calib.oneMill == 0) // Check the board calibration data is available.
    {
      Serial.println("TEST CANCELLED - NO CALIBRATION DATA");
    }
    else
    {

    }
  }



}
