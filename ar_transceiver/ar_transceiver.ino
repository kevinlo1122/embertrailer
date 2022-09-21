// libraries and imports
#include <SPI.h>
#include <RH_RF95.h>
#include <RHReliableDatagram.h>

// hardware definitions
#define RFM95_CS 4
#define RFM95_RST 2
#define RFM95_INT 3
#define RF95_FREQ 433.0

// program definitions
RH_RF95 rf95(RFM95_CS, RFM95_INT);
RHReliableDatagram rf95_manager(rf95, 111);

void bxor(uint8_t msg[], uint8_t buf[], uint8_t len, uint8_t key[]){
  for (int i = 0; i < len; i++){
    msg[i] = buf[i] ^ key[i];
  }
}

// setup and initialization
void setup()
{
  pinMode(RFM95_RST, OUTPUT);
  digitalWrite(RFM95_RST, HIGH);

  while (!Serial);
  Serial.begin(9600);
  delay(100);
  
  // manual reset
  digitalWrite(RFM95_RST, LOW);
  delay(10);
  digitalWrite(RFM95_RST, HIGH);
  delay(10);
  
  if(!rf95_manager.init()){
    Serial.println("rf95_manager init failed");
    while (1);
  }
  if (!rf95.init()){
    Serial.println("rf95 init failed");
    while (1);
  }
  if (!rf95.setFrequency(RF95_FREQ)){
    Serial.println("rf95.setFrequency failed");
    while (1);
  }
  rf95.setTxPower(23, false);

  // parameters and constants
  rf95.setThisAddress(111);
  rf95_manager.setRetries(10000);
}
  // parameters and constants pt2
uint8_t key[] = "MPOv5JeqL3rLeabWhTwPHIbCl0HiE9HFmddbNpnJgDobUjJGckMbbk4BvQSJ7zLtSnAgtYK1RHQjZCgzI8me4d1xRx9EUUGxVLWDAJiBTXTYxsajjm3WdQ9IiWgPQJhDGyECnZYIbt0JAUQ1FpggI8a5N46aFJ2rfo7Zc7Eh7ZX89T8O2pL3j55HPBOeQaNy2gk2V2LOpTNSDpHvwX41lFfEOsBJhnLnjCun8SHJaAmjAureTeSHY6udCz";
uint16_t recv_timeout = 32000;
uint8_t destination = 11;

// loop
void loop()
{
    uint8_t recv_buf[RH_RF95_MAX_MESSAGE_LEN] = {};
    uint8_t recv_msg[RH_RF95_MAX_MESSAGE_LEN] = {};
    uint8_t recv_len = sizeof(recv_buf);
    
    if (rf95_manager.recvfromAck(recv_buf, &recv_len)) {
      if (!recv_len) return;
      recv_buf[recv_len] = 0;
      bxor(recv_msg, recv_buf, recv_len, key);
//      Serial.print("Received Message:  ");
      Serial.println((char*)recv_msg);
//      delay(2000);
      String msg = Serial.readStringUntil('\n');
      uint8_t send_msg[msg.length()+1];
      msg.getBytes(send_msg, msg.length()+1);
//      uint8_t send_msg[] = "TEST/test/123/EOT";
      bxor(send_msg, send_msg, sizeof(send_msg), key);
      rf95_manager.sendtoWait(send_msg, sizeof(send_msg), destination);
    }
//    delay(2000);
}
