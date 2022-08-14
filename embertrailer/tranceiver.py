# libraries and imports
import time
import random
import busio
import board
import adafruit_rfm9x
from digitalio import DigitalInOut, Direction, Pull

# hardware definitions
CS = DigitalInOut(board.D5)
RESET = DigitalInOut(board.D6)
spi = busio.SPI(board.SCK, MOSI=board.MOSI, MISO=board.MISO)

# program definitions
def bxor(str, key):
    result = bytes("", "UTF-8")
    for str, key in zip(str, key):
        result += bytes([str ^ key])
    return result

# setup and initilization
while True:
    try:
        rfm9x = adafruit_rfm9x.RFM9x(spi, CS, RESET, 433.0)
        break
    except RuntimeError as error:
        print('RFM9x Error: ', error)
    time.sleep(1)

# parameters and constants
rfm9x.destination = 111
rfm9x.node = 11
rfm9x.enable_crc = True
rfm9x.ack_retries = 10000
rfm9x.receive_timeout = 32000 
rfm9x.ack_delay = 0.1
key = bytes("MPOv5JeqL3rLeabWhTwPHIbCl0HiE9HFmddbNpnJgDobUjJGckMbbk4BvQSJ7zLtSnAgtYK1RHQjZCgzI8me4d1xRx9EUUGxVLWDAJiBTXTYxsajjm3WdQ9IiWgPQJhDGyECnZYIbt0JAUQ1FpggI8a5N46aFJ2rfo7Zc7Eh7ZX89T8O2pL3j55HPBOeQaNy2gk2V2LOpTNSDpHvwX41lFfEOsBJhnLnjCun8SHJaAmjAureTeSHY6udCz", "UTF-8")

# loop
while True:
    # get sensor data, using random number and precision for now
    longitude = random.randint(-1380000, -1140000) / 10000
    latitude = random.randint(480000, 600000) / 10000
    temperature = random.randint(150, 500) / 10 
    battery = random.randint(0, 100)
    water = random.randint(0, 100)
    # ...

    send_message = bytes(str(longitude) + "/" + str(latitude) + "/" + str(temperature) + "/" + str(battery) + "/" + str(water) + "/" + "EOT", "UTF-8")
    print("Sending Message: ", send_message)
    rfm9x.send_with_ack(data=bxor(send_message, key))
    # time.sleep(2)
    received_message = bxor(rfm9x.receive(with_ack=True), key)
    print("Received Message: ", received_message)
    # time.sleep(2)
