# Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
# Вычисление осущеcтвил рекурсией.
# Старые куски кода закомментированы!

# def FactorialSeries(N):
#     if N == 0: return 1
#     resultСalc = N * FactorialSeries(N - 1)
#     print(resultСalc, end = " ")
#     return resultСalc

import math

userInput = int(input("Введите число: "))
res = [i for i in range (1, userInput+1)]
res = list(map(lambda temp: math.factorial(temp), res))

print (res)
