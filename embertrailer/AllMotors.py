import RPi.GPIO as GPIO          
from time import sleep


#######################################################################################
#DC Motor setup for supression
in1 = 1
in2 = 7
enA = 8
temp0=1

GPIO.setmode(GPIO.BCM)
GPIO.setup(in1,GPIO.OUT)
GPIO.setup(in2,GPIO.OUT)
GPIO.setup(enA,GPIO.OUT)
GPIO.output(in1,GPIO.LOW)
GPIO.output(in2,GPIO.LOW)
#set speed
p0=GPIO.PWM(enA,1000)
p0.start(100)
# print("\n")
# print("The default speed & direction of motor is LOW & Forward.....")
# print("r-run s-stop f-forward b-backward l-low m-medium h-high e-exit")
# print("\n")   


#######################################################################################
#DC Motor setup for drill
in3 = 0
in4 = 5
enB = 6
temp1=1

GPIO.setmode(GPIO.BCM)
GPIO.setup(in3,GPIO.OUT)
GPIO.setup(in4,GPIO.OUT)
GPIO.setup(enB,GPIO.OUT)
GPIO.output(in3,GPIO.LOW)
GPIO.output(in4,GPIO.LOW)
#set speed
p1=GPIO.PWM(enB,1000)
p1.start(25)
 

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

while(1):

    x=input()

#######################################################################################
    #Suppression 
    if x=='ss':
            print("Suppression stop")
            GPIO.output(in1,GPIO.LOW)
            GPIO.output(in2,GPIO.LOW)
            x='z'

    elif x=='sf':
        print("Suppression on")
        GPIO.output(in1,GPIO.HIGH)
        GPIO.output(in2,GPIO.LOW)
        temp0=0
        x='z'

    #######################################################################################
    #Drill Motor
    elif x=='ds':
        print("Drill stop")
        GPIO.output(in3,GPIO.LOW)
        GPIO.output(in4,GPIO.LOW)
        x='z'

    elif x=='df':
        print("Drill forward")
        GPIO.output(in3,GPIO.HIGH)
        GPIO.output(in4,GPIO.LOW)
        temp1=1
        x='z'

    elif x=='db':
        print("Drill backward")
        GPIO.output(in3,GPIO.LOW)
        GPIO.output(in4,GPIO.HIGH)
        temp1=0
        x='z'

    elif x=='dl':
        print("Drill speed low")
        p1.ChangeDutyCycle(25)
        x='z'

    elif x=='dm':
        print("Drill speed medium")
        p1.ChangeDutyCycle(50)
        x='z'

    elif x=='dh':
        print("Drill speed high")
        p1.ChangeDutyCycle(100)
        x='z'

    ####################################################################################### 
    #Linear Actuator    
    elif x=='ld':
        print("Linear Actuator down")
        sleep(1.0)
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
        x='z' 

    elif x=='lu':
        print("Linear Actuator up")
        sleep(1.0)
        GPIO.output(DIR,CCW)
        for x in range(6400):
            GPIO.output(STEP,GPIO.HIGH)
            sleep(.00005)
            GPIO.output(STEP,GPIO.LOW)
            sleep(.00005)
        x='z'         

    #stop program
    elif x=='e':
        GPIO.cleanup()
        break

    else:
        print("<<<  wrong data  >>>")
        print("please enter the defined data to continue.....")
