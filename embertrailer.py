# libraries and imports
from time import sleep, monotonic
import board
import busio
import digitalio
import serial

import adafruit_dht
import adafruit_mcp3xxx.mcp3008 as MCP
from adafruit_mcp3xxx.analog_in import AnalogIn
import adafruit_gps
import adafruit_amg88xx
import adafruit_rfm9x

# helper definitions
def normalize(x, in_min, in_max, out_min, out_max):
    return int((x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min)

def bxor(str, key):
    result = bytes("", "UTF-8")
    for str, key in zip(str, key):
        result += bytes([str ^ key])
    return result

def format_send_message(values):
    message = ""
    for value in values:
        message = message + str(value) + "/"
    message += "EOT"
    return bytes(message, "UTF-8")


# get sensor data functions
def get_dht(dht):
    return dht.temperature, dht.humidity

def get_mq135(channel_0):
    return normalize(channel_0.value, 0, 60000, 0, 100)

def get_featherwing(gps, last_print):
    gps.update()
    current = monotonic()
    if current - last_print >= 1.0:
        last_print = current
        if not gps.has_fix:
            return None, None
        return gps.latitude, gps.longitude
    else:
        return None, None

def get_amg8333(amg):
    pixels = amg.pixels
    return pixels, max(map(max, pixels))

# setup
while True:
    try:
        spi = busio.SPI(clock=board.SCK, MISO=board.MISO, MOSI=board.MOSI)

        dht = adafruit_dht.DHT11(board.D17)

        mcpcs = digitalio.DigitalInOut(board.D23)
        mcp = MCP.MCP3008(spi, mcpcs)
        channel_0 = AnalogIn(mcp, MCP.P0)

        uart = serial.Serial("/dev/ttyS0", baudrate=9600, timeout=10)
        gps = adafruit_gps.GPS(uart, debug=False)
        gps.send_command(b"PMTK314,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0")
        gps.send_command(b"PMTK220,1000")
        last_print = monotonic()

        i2c = busio.I2C(board.SCL, board.SDA)
        amg = adafruit_amg88xx.AMG88XX(i2c)

        rfm9xcs = digitalio.DigitalInOut(board.D5)
        rfm9xreset = digitalio.DigitalInOut(board.D6)
        rfm9x = adafruit_rfm9x.RFM9x(spi, rfm9xcs, rfm9xreset, 433.0)
        rfm9x.destination = 111
        rfm9x.node = 11
        rfm9x.enable_crc = True
        key = bytes("MPOv5JeqL3rLeabWhTwPHIbCl0HiE9HFmddbNpnJgDobUjJGckMbbk4BvQSJ7zLtSnAgtYK1RHQjZCgzI8me4d1xRx9EUUGxVLWDAJiBTXTYxsajjm3WdQ9IiWgPQJhDGyECnZYIbt0JAUQ1FpggI8a5N46aFJ2rfo7Zc7Eh7ZX89T8O2pL3j55HPBOeQaNy2gk2V2LOpTNSDpHvwX41lFfEOsBJhnLnjCun8SHJaAmjAureTeSHY6udCz", "UTF-8")
        rfm9x.ack_retries = 10000
        rfm9x.receive_timeout = 32000 
        rfm9x.ack_delay = 0.1
        break
    except RuntimeError as error:
        print("Setup Error: ", error)
    
    sleep(1)


# main loop
while True:
    try:
        # get sensor data
        ambient_temperature, humidity = get_dht(dht)
        air_quality = get_mq135(channel_0)
        latitude, longitude = get_featherwing(gps, last_print)
        matrix, hotspot = get_amg8333(amg)

        # format message
        send_message = format_send_message([ambient_temperature, humidity, air_quality, latitude, longitude, hotspot])
        # send message
        print("Send Message:     ", send_message.decode("UTF-8"))
        rfm9x.send_with_ack(data=bxor(send_message, key))

        # receive message
        received_message = bxor(rfm9x.receive(with_ack=True), key)
        print("Received Message: ", received_message.decode("UTF-8"))


    except RuntimeError as error:
        print("Main Loop Error: ", error)

    sleep(1)
    
