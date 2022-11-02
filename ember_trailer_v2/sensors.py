# software/system libraries
from time import sleep

# hardware/sensor librares
import board
import busio
import digitalio
import serial
import adafruit_dht
import adafruit_mcp3xxx.mcp3008
import adafruit_mcp3xxx.analog_in
import adafruit_gps
import adafruit_amg88xx


class sensors:
    try:
        # SPI bus
        spi = busio.SPI(clock=board.SCK, MISO=board.MISO, MOSI=board.MOSI)

        # temperature/humidity sensor
        dht = adafruit_dht.DHT11(board.D27)
        
        # gas sensor
        mcpcs = digitalio.DigitalInOut(board.D23)
        mcp = adafruit_mcp3xxx.mcp3008.MCP3008(spi, mcpcs)
        channel_0 = adafruit_mcp3xxx.analog_in.AnalogIn(mcp, adafruit_mcp3xxx.mcp3008.P0)

        # gps
        uart = serial.Serial("/dev/ttyS0", baudrate=9600, timeout=10)
        gps = adafruit_gps.GPS(uart, debug=False)
        gps.send_command(b"PMTK314,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0")
        gps.send_command(b"PMTK220,1000")

        # thermal camera
        i2c = busio.I2C(board.SCL, board.SDA)
        amg = adafruit_amg88xx.AMG88XX(i2c)
        
        # give time to setup
        sleep(2)

    except Exception as error:
        print("Sensor Setup Error: ", error)
        exit()


    # functions    
    def get_temp(self):
        return self.dht.temperature
    
    def get_humidity(self):
        return self.dht.humidity

    def get_air_quality(self):
        return self.channel_0.value

    def get_location(self):
        self.gps.update()
        if self.gps.has_fix:
            return self.gps.latitude, self.gps.longitude
        else:
            return None, None

    def get_thermal_image_max(self):
        pixels = self.amg.pixels
        return max(map(max, pixels))
