# software/system libraries
from time import sleep

# hardware/radio libraries
import busio
import board
import adafruit_rfm9x
from digitalio import DigitalInOut


class radio:
    try:
        # radio
        CS = DigitalInOut(board.D5)
        RESET = DigitalInOut(board.D6)
        spi = busio.SPI(board.SCK, MOSI=board.MOSI, MISO=board.MISO)
        rfm9x = adafruit_rfm9x.RFM9x(spi, CS, RESET, 433.0)
        key = bytes("MPOv5JeqL3rLeabWhTwPHIbCl0HiE9HFmddbNpnJgDobUjJGckMbbk4BvQSJ7zLtSnAgtYK1RHQjZCgzI8me4d1xRx9EUUGxVLWDAJiBTXTYxsajjm3WdQ9IiWgPQJhDGyECnZYIbt0JAUQ1FpggI8a5N46aFJ2rfo7Zc7Eh7ZX89T8O2pL3j55HPBOeQaNy2gk2V2LOpTNSDpHvwX41lFfEOsBJhnLnjCun8SHJaAmjAureTeSHY6udCz", "UTF-8")

        # give time to setup
        sleep(0.5)

    except Exception as error:
        print("Radio Setup Error: ", error)
        exit()

    
    # functions
    def bxor(self, str):
        result = bytes("", "UTF-8")
        for str, k in zip(str, self.key):
            result += bytes([str ^ k])
        return result

    def format_message(self, values):
        message = ""
        for value in values:
            message = message + str(value) + "/"
        message += "EOT"
        return bytes(message, "UTF-8")

    def send(self, values):
        msg = self.format_message(values)
        enc_msg = self.bxor(msg)
        self.rfm9x.send(data=enc_msg)
