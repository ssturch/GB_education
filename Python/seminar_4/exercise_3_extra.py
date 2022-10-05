# Задайте последовательность цифр. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности. 
# Решение без использования множеств, используя регулярку.
import re

isError = True
while isError == True:
    userInput = input("Введите последовательность чисел: ")
    if userInput.isnumeric() == True: isError = False
    else: print("Ошибка ввода, повторите ввод!")

sortInput = ''.join(sorted(userInput))
regExp = r"\d"
result = []

while re.search(regExp,sortInput) != None or len(sortInput) != 0:
    minElement = sortInput[0]
    regExp = rf"{minElement}" + "{2,}"
    if re.search(regExp,sortInput) == None and len(sortInput) != 0:
        result.append(sortInput[0])
        sortInput = sortInput.replace(sortInput[0], '', 1)
    else:    
        sortInput = re.sub(regExp,'',sortInput,1)
        
if len(result): print(f"Результат: {result}") 
else: print("В данной последовательности нет уникальных чисел!")

        

    