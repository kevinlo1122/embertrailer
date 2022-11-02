# software libraries
from time import sleep

# hardware libraries
import RPi.GPIO as GPIO


class alerts:
    try:
        # setup GPIO pin mode
        GPIO.setmode(GPIO.BCM)
        GPIO.setwarnings(False)

        # buzzer
        buzzer = 26
        GPIO.setup(buzzer, GPIO.OUT)

        # RGB led
        red =  17 
        green = 16
        blue = 22
        GPIO.setup(red, GPIO.OUT)
        GPIO.setup(green, GPIO.OUT)
        GPIO.setup(blue, GPIO.OUT)
        RED = GPIO.PWM(red, 100)
        GREEN = GPIO.PWM(green, 100)
        BLUE = GPIO.PWM(blue, 100)
        RED.start(0)
        GREEN.start(0)
        BLUE.start(0)

        sleep(0.5)

    except Exception as error:
        print("Alerts Setup Error: ", error)
        exit()

    
    def play_sound(self):
        for j in range(2):
            for i in range(100):
                GPIO.output(self.buzzer, GPIO.HIGH)
                sleep(0.002)
                GPIO.output(self.buzzer, GPIO.LOW)
                sleep(0.002)
            sleep(0.3)

    def setColor(self, rgb = []):
        rgb = [(x / 255.0) * 100 for x in rgb]
        self.RED.ChangeDutyCycle(rgb[0])
        self.GREEN.ChangeDutyCycle(rgb[1])
        self.BLUE.ChangeDutyCycle(rgb[2])

    def color_map(self, minimum, maximum, temp):
        minimum, maximum = float(minimum), float(maximum)
        ratio = 2 * (temp-minimum) / (maximum - minimum)
        b = int(max(0, 255*(1 - ratio)))
        r = int(max(0, 255*(ratio - 1)))
        g = 255 - b - r
        return r, g, b

    def change_color(self, temp):
        self.setColor(self.color_map(0, 80, temp)) # -20 looks better than 0, green will be around ~20 degrees ambient


