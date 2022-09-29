# Задайте список из n чисел последовательности (1+1/n)^n и выведите на экран их сумму.
# Вычисление осущеcтвил рекурсией. По моему, получилось красиво :) 

def eSeries(n, arr):
    if n == 0: 
        arr.reverse()
        return arr
    resultСalc = (1 + 1 / n) ** n
    arr.append(resultСalc)
    return eSeries(n - 1, arr)
    
userInput = int(input("Введите число: "))
outputResult = eSeries(userInput, [])
print(f"Задана последовательность: {outputResult}")
print(f"Сумма элементов последовательности: {sum(outputResult)}")


