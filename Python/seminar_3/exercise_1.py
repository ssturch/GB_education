# Задайте рандомно список из чисел размером N, где N число с клавиатуры. 
# Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

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

def OddPosSummArr(arr):
    summ = 0
    for i in range(len(arr)): 
        if i % 2 != 0: summ += arr[i]
    return (summ)

userInput = int(input("Введите число N: "))
outputArr = RandomList(userInput)
print(f"Получен массив: {outputArr}")
print(f"Сумма элементов на нечетной позиции = {OddPosSummArr(outputArr)}")