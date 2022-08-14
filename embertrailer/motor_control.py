import RPi.GPIO as GPIO          
from time import sleep
import sys

GPIO.setwarnings(False)

#######################################################################################
#DC Motor setup for supression
in1 = 1
in2 = 7
enA = 8

GPIO.setmode(GPIO.BCM)
GPIO.setup(in1,GPIO.OUT)
GPIO.setup(in2,GPIO.OUT)
GPIO.setup(enA,GPIO.OUT)
GPIO.output(in1,GPIO.LOW)
GPIO.output(in2,GPIO.LOW)
#set speed
p0=GPIO.PWM(enA,1000)
p0.start(100) 


#######################################################################################
#DC Motor setup for drill
in3 = 0
in4 = 5
enB = 6

GPIO.setmode(GPIO.BCM)
GPIO.setup(in3,GPIO.OUT)
GPIO.setup(in4,GPIO.OUT)
GPIO.setup(enB,GPIO.OUT)
GPIO.output(in3,GPIO.LOW)
GPIO.output(in4,GPIO.LOW)
#set speed
p1=GPIO.PWM(enB,1000)
p1.start(100)
 

#######################################################################################
#Linear Actuator setup 
# Direction pin from controller
DIR = 20
# Step pin from controller
STEP = 26
# 0/1 used to signify clockwise or counterclockwise.
CW = 1
CCW = 0

# Setup pin layout on PI
GPIO.setmode(GPIO.BCM)

# Establish Pins in software
GPIO.setup(DIR, GPIO.OUT)
GPIO.setup(STEP, GPIO.OUT)

# Set the first direction you want it to spin
GPIO.output(DIR, CW)

x=sys.argv[1]

#######################################################################################
#Suppression
if x=='s':      # spray water for 3 seconds
    print("Suppression on")
    GPIO.output(in1,GPIO.HIGH)
    GPIO.output(in2,GPIO.LOW)
    sleep(3)
    print("Suppression stop")
    GPIO.output(in1,GPIO.LOW)
    GPIO.output(in2,GPIO.LOW)

#######################################################################################
#Drill Motor
elif x=='d':    # drill for 5 seconds, then reverse
    print("Drill forward")
    GPIO.output(in3,GPIO.HIGH)
    GPIO.output(in4,GPIO.LOW)
    sleep(5)
    print("Drill stop")
    GPIO.output(in3,GPIO.LOW)
    GPIO.output(in4,GPIO.LOW)
    sleep(0.1)
    print("Drill backward")
    GPIO.output(in3,GPIO.LOW)
    GPIO.output(in4,GPIO.HIGH)
    sleep(5)

####################################################################################### 
#Linear Actuator    
elif x=='ld':
    print("Linear Actuator down")
    # Esablish the direction you want to go
    GPIO.output(DIR,CW)

    # Run for 6400 steps. This will change based on how you set you controller
    for x in range(6400):

        # Set one coil winding to high
        GPIO.output(STEP,GPIO.HIGH)
        # Allow it to get there.
        sleep(.00005) # Dictates how fast stepper motor will run
        # Set coil winding to low
        GPIO.output(STEP,GPIO.LOW)
        sleep(.00005) # Dictates how fast stepper motor will run            


elif x=='lu':
    print("Linear Actuator up")
    GPIO.output(DIR,CCW)
    for x in range(6400):
        GPIO.output(STEP,GPIO.HIGH)
        sleep(.00005)
        GPIO.output(STEP,GPIO.LOW)
        sleep(.00005)


GPIO.cleanup()
exit()
