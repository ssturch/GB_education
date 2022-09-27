# Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
# Вычисление осущетсвил рекурсией.

def FactorialSeries(N):
    if N == 0: return 1
    resultСalc = N * FactorialSeries(N - 1)
    print(resultСalc, end = " ")
    return resultСalc
    
userInput = int(input("Введите число: "))
FactorialSeries(userInput)
