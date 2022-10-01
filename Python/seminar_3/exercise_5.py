# Задайте число - размер списка. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
userInput = int(input("Введите число: "))
rightArr = [None] * (userInput + 1)
leftArr = [None] * (userInput + 1)
for i in range(userInput + 1):
    if i == 0: rightArr[0] = 0; leftArr[-1] = 0
    if i == 1: rightArr[1] = 1; leftArr[-2] = 1
    if i >= 2: 
       rightArr[i] = rightArr[i - 2] + rightArr[i - 1]
       leftArr[-i - 1] = leftArr[-i + 1] - leftArr[-i] 
leftArr.pop(userInput)
resultArr = leftArr + rightArr

print(f"Результат: {resultArr}")

         