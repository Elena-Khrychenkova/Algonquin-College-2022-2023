from sense_hat import SenseHat
import time

s = SenseHat()
s.low_light = True

green = (0, 255, 0)
yellow = (255, 255, 0)
blue = (0, 0, 255)
red = (255, 0, 0)
white = (255, 255, 255)
nothing = (0, 0, 0)
pink = (255, 105, 180)
o = (0, 0, 0)
grey = (220, 220, 220)

def getUserChoice():
    userChoice = -1
    print('What do you want to display? Please see the options below and enter the number between 1 and 6:')
    print('Menu')
    print('1. Logo')
    print('2. Plus sign')
    print('3. Equals sign')
    print('4. Raspberry')
    print('5. Heart')
    print('6. Elephant')
    print('0. Exit')
    while userChoice < 0:
        try:
            userChoice = int(input('Your choice: '))
        except ValueError:
            print('Please enter a valid number!!!')
        if userChoice > 6:
           userChoice = -1
           print('Please enter a valid number!!!')
    if userChoice == 1:
        x = 0
    elif userChoice == 2:
            x = 1
    elif userChoice == 3:
            x = 2
    elif userChoice == 4:
            x = 3
    elif userChoice == 5:
            x = 4
    elif userChoice == 6:
            x = 5
    elif userChoice == 0:
            x = 6
            print('Bye!')
    return x

def trinket_logo(G = green, Y = yellow, B = blue, O = nothing):
    logo = [
    O, O, O, O, O, O, O, O,
    O, Y, Y, Y, B, G, O, O,
    Y, Y, Y, Y, Y, B, G, O,
    Y, Y, Y, Y, Y, B, G, O,
    Y, Y, Y, Y, Y, B, G, O,
    Y, Y, Y, Y, Y, B, G, O,
    O, Y, Y, Y, B, G, O, O,
    O, O, O, O, O, O, O, O,
    ]
    return logo

def raspi_logo(G = green, R = red, O = nothing):
    logo = [
    O, G, G, O, O, G, G, O,
    O, O, G, G, G, G, O, O,
    O, O, R, R, R, R, O, O,
    O, R, R, R, R, R, R, O,
    R, R, R, R, R, R, R, R,
    R, R, R, R, R, R, R, R,
    O, R, R, R, R, R, R, O,
    O, O, R, R, R, R, O, O,
    ]
    return logo

def plus(W = white, O = nothing):
    logo = [
    O, O, O, O, O, O, O, O,
    O, O, O, W, W, O, O, O,
    O, O, O, W, W, O, O, O,
    O, W, W, W, W, W, W, O,
    O, W, W, W, W, W, W, O,
    O, O, O, W, W, O, O, O,
    O, O, O, W, W, O, O, O,
    O, O, O, O, O, O, O, O,
    ]
    return logo

def equals(W = white, O = nothing):
    logo = [
    O, O, O, O, O, O, O, O,
    O, W, W, W, W, W, W, O,
    O, W, W, W, W, W, W, O,
    O, O, O, O, O, O, O, O,
    O, O, O, O, O, O, O, O,
    O, W, W, W, W, W, W, O,
    O, W, W, W, W, W, W, O,
    O, O, O, O, O, O, O, O,
    ]
    return logo

def heart(P = pink, O = nothing):
    logo = [
    O, O, O, O, O, O, O, O,
    O, P, P, O, P, P, O, O,
    P, P, P, P, P, P, P, O,
    P, P, P, P, P, P, P, O,
    O, P, P, P, P, P, O, O,
    O, O, P, P, P, O, O, O,
    O, O, O, P, O, O, O, O,
    O, O, O, O, O, O, O, O,
    ]
    return logo

def elephant(O = nothing, c2 = white, c1 = grey):
    logo = [
        o, o, c1, c1, o, o, o, o,
        o, c1, c1, c1, c1, c1, c1, o,
        c1, o, c1, c1, c1, c1, c1, c1,
        c1, c1, c1, c1, c1, c1, c1, c1,
        c1, c2, c2, c1, c1, c1, c1, c1,
        c1, o, c1, c1, c1, c1, c1, c1,
        c1, o, c1, c1, o, c1, c1, o,
        c1, o, c2, c1, o, c2, c1, o,
    ]
    return logo


images = [trinket_logo, plus, equals, raspi_logo, heart, elephant]

while True:
    x = getUserChoice()
    if x == 6:
        break
    s.set_pixels(images[x]())
    time.sleep(.75)













