from mysql.connector import MySQLConnection, Error

from mySqlDbConfig import readDbConfig



def insertGrade(firstName, lastName, province, grade):
    try:
        dbconfig = readDbConfig()
        conn = MySQLConnection(**dbconfig)
        cursor = conn.cursor()
        cursor.execute("INSERT INTO grades (FName, LName, Province, Grade)" 
                       "VALUES ('{}', '{}', '{}', '{}')".format(firstName, lastName, province, grade))
        conn.commit()
    except Error as e:
        print(e)
    finally:
        cursor.close()
        conn.close()


def deleteGrade(firstName, lastName, province, grade):
    try:
        dbconfig = readDbConfig()
        conn = MySQLConnection(**dbconfig)
        cursor = conn.cursor()
        cursor.execute("DELETE FROM grades WHERE FName = '{}' AND LName = '{}' AND Province = '{}' AND Grade = '{}'".format(firstName, lastName, province, grade))
        conn.commit()
    except Error as e:
        print(e)
    finally:
        cursor.close()
        conn.close()


def displayGrade(firstName, lastName, province):
    try:
        dbconfig = readDbConfig()
        conn = MySQLConnection(**dbconfig)
        cursor = conn.cursor()
        cursor.execute("SELECT * FROM grades WHERE FName LIKE '%{}%' AND LName LIKE '%{}%' AND Province LIKE '%{}%'".format(firstName, lastName, province))
        row = cursor.fetchone()
        print("<table>")
        while row is not None:
            print("<tr><td>{}</td><td>{}</td><td>{}</td><td>{}</td></tr>".format(row[0], row[1], row[2], row[3]))
            row = cursor.fetchone()
        print("</table>")
    except Error as e:
        print(e)
    finally:
        cursor.close()
        conn.close()


print('Menu')
print('1. Enter a grade')
print('2. Display a grade')
print('3. Delete a grade')
print('4. Exit')

while True:
    try:
        userInput = int(input('Please choose the option between 1 and 4: '))
        if userInput == 1:
            lastName = input('Please enter the last name: ')
            firstName = input('Please enter the first name: ')
            province = input('Please enter the province: ')
            grade = input('Please enter the grade: ')
            insertGrade(firstName, lastName, province, grade)
        elif userInput == 2:
            firstName = input('Please enter the first name: ')
            lastName = input('Please enter the last name: ')
            province = input('Please enter the province: ')
            displayGrade(firstName, lastName, province)
        elif userInput == 3:
            lastName = input('Please enter the last name: ')
            firstName = input('please enter the first name: ')
            province = input('Please enter the province: ')
            grade = input('Please enter the grade: ')
            deleteGrade(firstName, lastName, province, grade)
        elif userInput == 4:
            print('You have just exited')
        else:
            print('The option should be between numbers 1 and 4')
    except ValueError:
        print('Please input the valid number')










