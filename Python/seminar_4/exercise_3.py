# Задайте последовательность цифр. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности. 
# Решать через словари удобно, но необязательно

isError = True
while isError == True:
    userInput = input("Введите последовательность чисел: ")
    if userInput.isnumeric() == True: isError = False
    else: print("Ошибка ввода, повторите ввод!")

inputList = list(userInput)
lot = set(inputList) # Множество уникальных элементов
result = []

for i in lot:
    repeat = 0
    for j in range(len(inputList)):
        if inputList[j] == i: repeat += 1; tempj = j
        if repeat > 1: tempj = None; break
    if tempj != None: result.append(inputList[tempj])

if len(result): print(f"Результат: {result}") 
else: print("В данной последовательности нет уникальных чисел!")


        

    