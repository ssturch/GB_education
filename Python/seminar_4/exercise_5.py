#Даны два файла, в каждом из которых находится запись многочлена.
#Задача - сформировать файл, содержащий сумму многочленов.
import re

def DigestionStrEquation(equa):
    if equa != None or '':
        regExp = r"([+-]*\d*x\^\d+)*([+-]\d*x?)?([+-]\d*)?=0$" #Регулярку бы стоило доработать... Я устал уже)))
        check = re.fullmatch(regExp, equa, flags=0)
        if check == None: print ("Входящее выражение неверно!")
        else:
            matches = re.findall(r'([+-]*\d*x\^\d+)', equa)
            print(matches)

DigestionStrEquation('3x^5-9x^4+6x^3+2x^2+3x+2=0')
