 # Напишите программу, которая найдёт произведение пар чисел списка (Список создаем как в предыдущем задании).
 # Парой считаем первый и последний элемент, второй и предпоследний и т.д.

import psutil
import math

def RandomDigit(dig):
    a = 0
    while a == 0:
        a = sum(psutil.cpu_percent(interval=0.1, percpu=True))
    b = psutil.cpu_count()
    c = math.log(a, b)
    d = int(str(c).split(".")[1])
    res = d % (dig)
    return res

def RandomList(N):
    arr = []
    for i in range(N): arr.append(RandomDigit(10))
    return(arr)

def SpecPairMultArr(arr):
    resultArr = []
    lastInd = len(arr) - 1
    for i in range(len(arr)):
        if lastInd - i < i: break
        result = arr[i] * arr[lastInd - i] 
        resultArr.append(result)
    return resultArr

userInput = int(input("Введите число N: "))
outputArr = RandomList(userInput)
print(f"Получен список: {outputArr}")
print(f"Результирующий список = {SpecPairMultArr(outputArr)}")