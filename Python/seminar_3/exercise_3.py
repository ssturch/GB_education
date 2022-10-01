#Задайте список из вещественных чисел. 
# Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
import random

def RandomRealList(N):
    arr = []
    for i in range(N): arr.append(round(random.random() + random.randint(0,9),2))
    return arr

def MaxMinReadDiffArr(arr):
    tempArr = []
    for i in range(len(arr)):
        resdigit = arr[i] % 1
        if resdigit != 0: tempArr.append(arr[i] % 1)
    return max(tempArr) - min(tempArr)

userInput = int(input("Введите число N: "))
outputArr = RandomRealList(userInput)
print(f"Получен список: {outputArr}")
print(f"Результат = {round(MaxMinReadDiffArr(outputArr),2)}")


        


