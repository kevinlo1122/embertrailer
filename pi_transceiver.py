import time
import busio
import board
from digitalio import DigitalInOut, Direction, Pull
import adafruit_rfm9x

CS = DigitalInOut(board.D5)
RESET = DigitalInOut(board.D6)
spi = busio.SPI(board.SCK, MOSI=board.MOSI, MISO=board.MISO)
packets_received = 0;

while True:
    try:
        rfm9x = adafruit_rfm9x.RFM9x(spi, CS, RESET, 433.0)
        print('RFM9x: Detected')
        break
    except RuntimeError as error:
        print('RFM9x: ERROR')
        print('RFM9x Error: ', error)
        
while True:
    packet = rfm9x.receive()
    if packet is None:
        print("None")
    else:
        print(packet)
        print(packets_received)
        packets_received = packets_received + 1
    time.sleep(1)
    
