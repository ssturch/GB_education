# Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.

isError = True
while isError == True:
    userInput = input("Введите натуральное число: ")
    if userInput.isnumeric() == True: isError = False; userInput = int(userInput)
    else: print("Ошибка ввода, повторите ввод!")

result = []

for i in range(1, userInput + 1):
    if userInput % i == 0: result.append(i)

print(f"Список простых множителей числа {userInput}: {result}")

