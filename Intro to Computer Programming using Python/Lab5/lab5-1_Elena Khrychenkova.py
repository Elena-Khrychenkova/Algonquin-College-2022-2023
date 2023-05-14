from sense_hat import SenseHat
import random

s = SenseHat()
s.low_light = True

pink = (255, 105, 180)
nothing = (0, 0, 0)

#Rollind a dice:
def rollAdice(num):
        userGets = random.randint(1, num)
        return userGets

while True:
        try:
          num = int(input('Please enter the number of faces of the dice: '))
          if num < 1:
           print('Please enter the number between 1 and 64')
          elif num > 64:
           print('Please enter the number between 1 and 64')
          elif num in range(65):
            list = []
            userGets = rollAdice(num)
            for i in range(userGets):
                    list.append(pink)
            for i in range(64 - userGets):
                    list.append(nothing)
            s.set_pixels(list)
        except ValueError:
         print('Please enter a valid number')

