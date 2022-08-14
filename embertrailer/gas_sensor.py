from time import sleep
import busio
import digitalio
import board
import adafruit_mcp3xxx.mcp3008 as MCP
from adafruit_mcp3xxx.analog_in import AnalogIn

spi = busio.SPI(clock=board.SCK, MISO=board.MISO, MOSI=board.MOSI)
cs = digitalio.DigitalInOut(board.D23)
mcp = MCP.MCP3008(spi, cs)
channel_0 = AnalogIn(mcp, MCP.P0)

def _range(x, in_min, in_max, out_min, out_max):
    return int((x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min)

while True: 
    print(_range(channel_0.value, 0, 60000, 0, 100))
    sleep(0.5)
