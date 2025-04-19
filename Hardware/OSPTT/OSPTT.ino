  // Definitions, libraries
#include <Mouse.h>
#include <Keyboard.h>
#include <INA220.h>
#include <FlashStorage.h>

#define INPUT_SIZE 12

#define ArraySize 12000

int LEDPin = 3; //19   // first analog sensor
int inByte = 0;         // incoming serial byte
int MotorEn = 12;   // Motor Enable
int MotorDir = 10;    // Motor Phase
int MotornSleep = 11;   // nSleep
int ForceSensor = A0;    // Force Sensor

#define OUT 1
#define IN 0

uint16_t adcBuff[ArraySize];
 
float firmwareVersion = 1.0;

char input[INPUT_SIZE + 1];

bool LEDState = false;

INA220 ina220;

// Board calibration data, will be wiped from new firmware updates
// So this is stored in the desktop app based on the board ID and
// on the download card included in the box. Should it be missing
// the user will need to input the data from the card from the 
// desktop app. 
typedef struct {
  int oneMill;
  int pointOneMill;
  int boardId;
} Calibration;

FlashStorage( my_flash_store, Calibration);

Calibration calib;