  // Definitions, libraries
#include <Mouse.h>
#include <Keyboard.h>
#include <INA220.h>

#define INPUT_SIZE 9

#define ArraySize 12000

int LEDPin = 3; //19   // first analog sensor
int inByte = 0;         // incoming serial byte
int MotorEn = 12;   // Motor Enable
int MotorDir = 10;    // Motor Phase
int MotornSleep = 11;   // nSleep
int ForceSensor = 5;    // Force Sensor

uint16_t adcBuff[ArraySize];
 
float firmwareVersion = 1.0;

char input[INPUT_SIZE + 1];

bool LEDState = false;

INA220 ina220;