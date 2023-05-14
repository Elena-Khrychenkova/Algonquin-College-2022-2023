from gtts import gTTS

import os

d = {'a':'alfa', 'b':'bravo', 'c':'charlie', 'd':'delta', 'e':'echo', 'f':'foxtrot', 'g':'golf', 'h':'hotel','i':'india', 'j':'juliett', 'k':'kilo', 'l':'lima','m':'mike', 'n':'november', 'o':'oscar', 'p':'papa', 'q':'quebec', 'r':'romeo','s':'sierra', 't':'tango', 'u':'uniform', 'v':'victor', 'w':'whiskey','x':'x-ray', 'y':'yankee', 'z':'zulu'}
f = open('readme.txt', 'r')
myName = (f.read())
myNameList = list(myName.lower())

def stringToICAO(myNameList, d):
    
    newList = []
    for i in myNameList:
        if i != ' ':
            newWord = d.get(i)
            newList.append(newWord)
        if i == ' ':
            continue
    else:
        result = '.'.join(newList)
        return result

x = stringToICAO(myNameList, d)
language = 'en'
result = gTTS(text=x, lang=language, slow=False)
result.save('elena_khrychenkova.mp3')
os.system('elena_khrychenkova.mp3')
    

