# Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
isError = True
while isError == True:
    userInput = input("Введите натуральное число: ")
    if userInput.isnumeric() != True and (0.0000000001 <= float(accuracyInput) <= 0.1): isError = False
    else: print("Ошибка ввода, повторите ввод!")
