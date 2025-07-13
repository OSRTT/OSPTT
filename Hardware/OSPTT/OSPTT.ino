  // Definitions, libraries
#include <Mouse.h>
#include <Keyboard.h>
#include <at24c256.h>
#include "HX711.h"

#define INPUT_SIZE 12

#define ArraySize 12000

int LEDPin = 1; //19   // first analog sensor
int inByte = 0;         // incoming serial byte
int MotorEn = 12;   // Motor Enable
int MotorDir = 10;    // Motor Phase
int MotornSleep = 11;   // nSleep
int HXData = 4;       // HX711 Data Pin
int HXClock = 3;      // HX711 Clock Pin
int HESensor = A1;    // Hall Effect Sensor for motor position

#define OUT 0
#define IN 1
#define MIN_MOTOR_MOVE 0.1

uint16_t adcBuff[ArraySize];
 
float firmwareVersion = 1.0;

char input[INPUT_SIZE + 1];

bool LEDState = false;


int PointZeroTwo = 6; // 6ms pulse for 0.02mm avg movement
int PointZeroFive = 10; // 10mm pulse for 0.05mm avg movement
int PointFive = 50; // 50ms pulse for 0.5mm avg movement
typedef struct {
  int boardId;
  int hallData[501];
  int ScaleCalib; // 17050
} Calibration;

AT24C256 eprom(AT24C_ADDRESS_0);

Calibration calib;

HX711 scale;