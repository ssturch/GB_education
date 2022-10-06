# Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
import math

isError = True
while isError == True:
    userInput = input("Введите натуральное число: ")
    if userInput.isnumeric() == True: isError = False; userInput = int(userInput)
    else: print("Ошибка ввода, повторите ввод!")

result = []

dig = 2
result.append(1)
temp = userInput
while dig * dig <= temp:
    if temp % dig == 0: result.append(dig); temp //= dig;
    else: dig += 1
result.append(temp)
result = set(result)

print(f"Список простых множителей числа {userInput}: {result}")

