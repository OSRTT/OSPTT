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
  
    
  

  //ADC_Init();
  analogReadResolution(14);

  establishContact();  // send a byte to establish contact until receiver responds


}

void loop() {
  getSerialChars();
  



}
