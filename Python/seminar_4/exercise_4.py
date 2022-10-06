#Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k
#k - максимальная степень многочлена, следующий степень следующего на 1 меньше и так до ноля
#Коэффициенты расставляет random, поэтому при коэффициенте 0 просто пропускаем данную итерацию степени

import random, re, os

def MakeRawEquation(k, maxConst = 1):

    while k >= 0:
        randOper = None

        ## - случайная генерация оператора сложения или вычитания
        ##---------------------------------------------
        randOper = random.choice(['+', '-'])
        ##---------------------------------------------
        const = random.randint(0, maxConst) #генерируемый случайный множитель
        deg = "^" + str(k)  #генерируемая степень
        equatTerm = str(const) + "x" + deg #генерация члена уровнения

        result = equatTerm + randOper + str(MakeRawEquation(k - 1, maxConst)) 

        regExp = r"\WNone"
        result = re.sub(regExp,"=0",result,1)
        print(result)
        return result

def RoastRawEquation(equa):
    if equa != None or '':
        regExp = r"(\b0x\^\d)|(\b0x\^\d\+)|(x\^0)|(\^1\b)|([-+]0x\^\d)|(1(?=x\^[^0]))"
        #выражение \b0x\^\d исключает получение значения 0х^2 в начале, т.е. вместо 0x^2 - x = 0 будет - x = 0
        #выражение \b0x\^\d\+ исключает получение значения 0х^2+ в начале, т.е. вместо 0x^2 + x = 0 будет x = 0
        #выражение x\^0 исключает получение значения 5х^0, вместо него будет 5
        #выражение \^1\b исключает получение значения 5x^1, вместо него будет 5x
        #выражение [-+]0x\^\d как и первое выражение, только работающее в любом месте строки и захватывает с собой ненужный знак-оператор
        #выражение 1(?=x\^[^0]) исключает получение значения 1х и 1х^0, вместо него будет x или 1 соответственно
        result= re.sub(regExp,"",equa)
        result= re.sub(r'^[+]',"",result) #удаляет остатки после "прожарки" выражения, вместо +x+1=0, будет x+1=0
        return result
    else: return print("Входящее выражение пустое!")

def WriteToFile(path,txt):
    file = open(path, 'w')
    file.write(txt)
    file.close



isError = True
while isError == True:
    userInput = input("Введите натуральное число, обозначающее максимальную степень многочлена: ")
    if userInput.isnumeric() == True: isError = False; userInput = int(userInput)
    else: print("Ошибка ввода, повторите ввод!")

output = RoastRawEquation(MakeRawEquation(userInput))
print(f"Результат: {output}")
filepath = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\equa_ex4.eq'
WriteToFile(filepath, output)
