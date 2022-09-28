# Задайте список из N элементов, заполненных числами из промежутка [-N, N]. 
# Найдите произведение элементов на указанных позициях. Позиции хранятся в файле file.txt в одной строке одно число.
import os

def arrNumbers (n):
    arr = []
    for i in range (n * 2 + 1):
        arr.append(-1 * n + i)
    return arr

def summElByFilePos(filename, arr):
    result = 0
    file = open(filename, 'r')
    for line in file:
        line = line.rstrip('\n')
        if line.isdigit() and int(line) >= 0 and int(line) < len(arr): result += arr[int(line)]
    return result

userInput = int(input("Введите число: "))
resultArr = arrNumbers(userInput)
print(f"Получен список: {resultArr}")
currWorkDir = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\file.txt'
resultSumm = summElByFilePos(currWorkDir, resultArr)
print(f"Сумма элементов согласно позициям из файла = {resultSumm}")






