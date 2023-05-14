from sense_hat import SenseHat

s = SenseHat()
s.low_light = True

nothing = (0, 0, 0)
darkBlue = (1, 42, 137)
blue = (0, 0, 255)
lightGreen = (161, 230, 148)
green = (0, 255, 0)
red = (255, 0, 0)


#displaing color for temperature:
def displayColorForTemperature(n):
    if n >= -40 and n <= -10:
        x = 1
        return x
    elif n >= -9 and n <= 0:
        x = 2
        return x
    elif n >= 1 and n <= 15:
        x = 3
        return x
    elif n >= 16 and n <= 22:
        x = 4
        return x
    elif n >= 23:
        x = 5
        return x

while True:
   try:
       userChoice = float(input('Please enter the temperature: '))
       list = []
       if displayColorForTemperature(userChoice) == 1:
           for i in range(1, 65):
               list.append(darkBlue)
       elif displayColorForTemperature(userChoice) == 2:
           for i in range(1, 65):
               list.append(blue)
       elif displayColorForTemperature(userChoice) == 3:
           for i in range(1, 65):
               list.append(lightGreen)
       elif displayColorForTemperature(userChoice) == 4:
           for i in range(1, 65):
               list.append(green)
       elif displayColorForTemperature(userChoice) == 5:
           for i in range(1, 65):
               list.append(red)
       s.set_pixels(list)
   except ValueError:
       print('Please enter a valid number: ')




#switching on leds depending on humidity percent:
def LedsOnForHumidity(num):
    humidityIndex = (64 * (num/100))
    return humidityIndex

while True:
    try:
        userChoiceHum = int(input('Please enter the humidity: '))
        x = LedsOnForHumidity(userChoiceHum)
        list = []
        for i in range(64):
            if i < x:
                list.append(blue)
            else:
                list.append(nothing)
        s.set_pixels(list)
    except ValueError:
        print('Please enter a valid number: ')