#Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k
#k - максимальная степень многочлена, следующий степень следующего на 1 меньше и так до ноля
#Коэффициенты расставляет random, поэтому при коэффициенте 0 просто пропускаем данную итерацию степени

import random, re

def MakeRawEquation(k, maxConst = 9):

    while k >= 0:
        randOper = None
        ## - случайная генерация оператора сложения или вычитания
        ##---------------------------------------------
        if random.randint(1,9) % 2 == 0: randOper = "+"
        else: randOper = "-"
        ##---------------------------------------------
        const = random.randint(0, maxConst) #генерируемый случайный множитель
        deg = "^" + str(k)  #генерируемая степень
        equatTerm = str(const) + "x" + deg #генерация члена уровнения

        result = equatTerm + randOper + str(MakeRawEquation(k - 1, maxConst)) 

        regExp = r"\WNone"
        result = re.sub(regExp,"=0",result,1)
        return result

def RoastRawEquation(equa):
    if equa != None or '':
        regExp = r"(\b0x\^\d\+)|(x\^0)|(\^1\b)|([-+]0x\^\d)|(1(?=x))"
        #выражение \b0x\^\d\+- исключает получение значения 0х^2+ в начале, т.е. вместо 0x^2 + x = 0 будет x = 0
        #выражение x\^0 исключает получение значения 5х^0, вместо него будет 5
        #выражение \^1\b исключает получение значения 5x^1, вместо него будет 5x
        #выражение [-+]0x\^\d как и первое выражение, только работающее в любом месте строки и захватывает с собой ненужный знак-оператор
        #выражение 1(?=x) исключает получение значения 1х, вместо него будет x
        result= re.sub(regExp,"",equa)
        return result
    else: return print("Входящее выражение пустое!")

isError = True
while isError == True:
    userInput = input("Введите натуральное число, обозначающее максимальную степень многочлена: ")
    if userInput.isnumeric() == True: isError = False; userInput = int(userInput)
    else: print("Ошибка ввода, повторите ввод!")

print(f"Результат: {RoastRawEquation(MakeRawEquation(userInput))}")
