#Prompts the user for the number of Tests
#Note that this function will include call(s) to the input function
#Keep prompting until the number is an integer.
#Returns the number of Tests
def getNumberOfTests():
    while True:
        try:
            num = int(input('Please enter the number of Tests: '))
        except ValueError:
            print('Please enter an integer number')
        else:
            return num

#Prompts the user for the weigth of Assignments
#Note that this function will include call(s) to the input function
#Keep prompting until the number is a float >= 0 and <= 1
#Returns the weight of assignments
def getWeightOfAssignments():
    while True:
        try:
            wOfAssign = float(input('Please enter the weight of Assignments'))
            if wOfAssign < 0:
                print('Please enter the number between 0 and 1')
            elif wOfAssign > 1:
                print('Please enter the number between 0 and 1')
        except ValueError:
            print('Please enter the float number: ')
        else:
            return wOfAssign

#Prompts the user for the weigth of Midterms
#Note that this function will include call(s) to the input function
#Keep prompting until the number is a float >= 0 and <= 1
#Returns the weight of midterms
def getWeightOfMidTerms():
    while True:
        try:
            wOfMidTerms = float(input('Please enter the weight of Midterms'))
            if wOfMidTerms <0:
                print('Please enter the numner between 0 and 1')
            elif wOfMidTerms >1:
                print('Please enter the number between 0 and 1')
        except ValueError:
            print('Please enter the float number: ')
        else:
            return wOfMidTerms

#Prompts the user for the weigth of the final
#Note that this function will include call(s) to the input function
#Keep prompting until the number is a float >= 0 and <= 1
#Returns the weight of final
def getWeightOfFinal():
    while True:
        try:
            wFinal = float(input('Please enter the weight of Finals'))
            if wFinal <0:
                print('Please enter the numner between 0 and 1')
            elif wFinal >1:
                print('Please enter the number between 0 and 1')
        except ValueError:
            print('Please enter the float number: ')
        else:
            return wFinal


#returns True if the sum of the 3 arguments is 1, False otherwise
#Assign the default values 0.4 0.35 0.25 to wAssign, wMidtern and wFinal respectively
def checkWeights(wAssign = 0.4, wMidTerm = 0.35, wFinal = 0.25):
    num = wAssign + wMidTerm + wFinal
    if num == 1:
        return True
    else:
        return False


#calculate the numeric grade as specified in the course outline
def calculateNumericGrade(AvgAssignments,AvgTests,final,wOfAssign,wOfMidTerms,wFinal):
    numericGrade = AvgAssignments*wAssign+AvgTests*wMidTerm+final*wFinal
    return numericGrade

#convert the numeric grade to a letter according to the conversion table
#in the course outline
def calculateLetterGrade(numericGrade):
       if numericGrade >= 90 and numericGrade <= 100:
           return 'A+'
       elif numericGrade >= 85 and numericGrade <= 89:
           return 'A'
       elif numericGrade >= 80 and numericGrade <= 84:
           return 'A-'
       elif numericGrade >= 77 and numericGrade <= 79:
           return 'B+'
       elif numericGrade >= 73 and numericGrade <= 76:
           return 'B'
       elif numericGrade >= 70 and numericGrade <= 72:
           return 'B-'
       elif numericGrade >= 67 and numericGrade <= 69:
           return 'C+'
       elif numericGrade >= 63 and numericGrade <= 66:
           return 'C'
       elif numericGrade >= 60 and numericGrade <= 62:
           return 'C-'
       elif numericGrade >= 57 and numericGrade <= 59:
           return 'D+'
       elif numericGrade >= 53 and numericGrade <= 56:
           return 'D'
       elif numericGrade >= 50 and numericGrade <= 52:
           return 'D-'
       else:
           if 49 >= numericGrade <= 0:
               return 'F'

#Get the weight value of the assignments (call the appropriate function)
#Get the weight value of tests (call the appropriate function)
#Get the weight value of the final (call the appropriate function)
#Check the sum of weight values is 1 (call the appropriate function)
#Repeat the last four lines if not equal to 1

wAssign = getWeightOfAssignments()
wMidTerm = getWeightOfMidTerms()
wFinal = getWeightOfFinal()
checkWeights = checkWeights(wAssign, wMidTerm, wFinal)

while checkWeights != 1:
  wAssign = getWeightOfAssignments()
  wMidTerm = getWeightOfMidTerms()
  wFinal = getWeightOfFinal()


#Get the average grade obtained on the assignments
#Validate the input as a float between 0 and 100
AvgAssignments = float(input('Please enter your average grade: '))
while True:
    try:
        if AvgAssignments < 0:
            print('Please enter the number between 0 and 100')
        elif AvgAssignments > 100:
            print('Please enter the number between 0 and 1')
    except ValueError:
        print('Please enter the float number: ')
    break

#Get the number of tests (call the appropriate function)
#Prompt the user for each test grades and accumulate the value
#Validate the input as a float between 0 and 100
#Calculate the average test grade.
tests = getNumberOfTests()
gradesList = []
for i in range (tests):
    if i < tests:
        gradesList.append(float(input('What is the grade?')))
        i += 1
gradeAccum = sum(gradesList)
AvgTests = gradeAccum/tests


#Prompt and get the final grade
#Validate the input as a float between 0 and 100
final = float(input('Please enter your final grade: '))
while True:
    try:
        if final < 0:
            print('Please enter the number between 0 and 100')
        elif final > 100:
            print('Please enter the number between 0 and 1')
    except ValueError:
        print('Please enter the float number: ')
    break

#Calculate and display the final numeric grade (call the appropriate function)
print(calculateNumericGrade(AvgAssignments,AvgTests,final,wAssign,wMidTerm,wFinal))

#Calculate and display the final alphabetical grade (call the appropriate function)
print(calculateLetterGrade(calculateNumericGrade(AvgAssignments,AvgTests,final,wAssign,wMidTerm,wFinal)))