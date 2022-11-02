# system libraries
import threading
import time

# user defined libraries
import sensors
import radio
import alerts

# global variables
data = sensors.sensors()
radio = radio.radio()
alerts = alerts.alerts()

temp = None
humidity = None
air_quality = None
location = None, None
thermal_image_max = None

# gets sensor data in global variables
# if sensor fails, will use old value or return None
def get_data(overwrite=False):
    global temp, humidity, air_quality, location, thermal_image_max
    if overwrite == True:
        temp = None
        humidity = None
        air_quality = None
        location = None, None
        thermal_image_max = None
    temp = data.get_temp()
    humidity = data.get_humidity()
    air_quality = data.get_air_quality()
    location = data.get_location()
    thermal_image_max = data.get_thermal_image_max()
    time.sleep(10)

# alerts user of sensor data
def get_alerts():
    alerts.change_color(thermal_image_max)
    if thermal_image_max >= 50:
        alerts.play_sound()


while True:
    sensor_thread = threading.Thread(target=get_data, args=[True])
    sensor_thread.start()
    sensor_thread.join(2)
    print("Temperature: ", temp)
    print("Humidity: ", humidity)
    print("Air Quality: ", air_quality)
    print("Location: ", location)
    print("Thermal Camera Hotspot: ", thermal_image_max)
    print("")

    get_alerts()
    current_data = [temp, humidity, air_quality, location[0], location[1], thermal_image_max]
    radio.send(current_data)
