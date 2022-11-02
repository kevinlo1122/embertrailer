import sensors
import radio
import threading

import time

data = sensors.sensors()
radio = radio.radio()

temp = None
humidity = None
air_quality = None
location = None
thermal_image_max = None


def get_data():
    global temp, humidity, air_quality, location, thermal_image_max
    temp = data.get_temp()
    humidity = data.get_humidity()
    air_quality = data.get_air_quality()
    location = data.get_location()
    thermal_image_max = data.get_thermal_image_max()
    time.sleep(10)


while True:
    thread = threading.Thread(target=get_data)
    thread.start()
    thread.join(1)
    print("Temperature: ", temp)
    print("Humidity: ", humidity)
    print("Air Quality: ", air_quality)
    print("Location: ", location)
    print("Thermal Camera Hotspot: ", thermal_image_max)
    print("")

    radio.send([temp, humidity, air_quality, location, thermal_image_max])