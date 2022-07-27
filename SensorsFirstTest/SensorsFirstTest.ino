#include <max6675.h>
#include <DHT.h>
#include <Wire.h>
#include <Adafruit_AMG88xx.h>

//Thermocouple initializations
int thermoDO = 4;
int thermoCS = 5;
int thermoCLK = 6;
int thermocoupleTempC = 0;
MAX6675 thermocouple(thermoCLK, thermoCS, thermoDO);

//Gas Sensor initializations
int analogPin = A0;
int co2Raw = 0;
int co2ppm = 0;

//Ambient Temperature Sensor initializations
#define DHTPin 2
#define DHTType DHT22
int DHTTemp = 0;
DHT dht(DHTPin, DHTType);

//Thermal Camera initializations
Adafruit_AMG88xx amg;


void setup() {
  Serial.begin(9600);

  Serial.println("Begin Sensor Test:");
  dht.begin();
  
  delay(2000);
}

void loop() {
  //Read thermocouple data
  thermocoupleTempC = thermocouple.readCelsius();

  //Read gas sensor data
  co2Raw = analogRead(analogPin);

  //Read ambient temperature data
  DHTTemp = dht.readTemperature();

  //Output data to serial monitor
  Serial.print("Probe Temperature (C) = "); 
  Serial.println(thermocoupleTempC);
  
  Serial.print("Gas = ");
  Serial.println(co2Raw);

  Serial.print("Ambient Temperature (C) = ");
  Serial.println(DHTTemp);
   
 
   delay(1000);
}
