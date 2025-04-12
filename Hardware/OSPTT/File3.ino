void setup() {

  Serial.begin(115200);
  while (!Serial) {
    ;  // wait for serial port to connect. Needed for native USB port only
  }
  
  pinMode(PullDownPin, INPUT_PULLDOWN);
  pinMode(ButtonPin, INPUT_PULLUP);
  pinMode(LEDPin, OUTPUT);
  
  pinMode(PullUpPin, INPUT_PULLUP);
    
  

  //ADC_Init();
  analogReadResolution(14);

  establishContact();  // send a byte to establish contact until receiver responds


}

void loop() {
  getSerialChars();
  



}
