# Напишите программу, которая будет на вход принимать число N и выводить числа от -N до N
userInput = int(input("Введите число N: "))
print("Результат:", end = " ")

if userInput < 0: multiplier = -1
else: multiplier = 1

for i in range(-userInput, userInput + multiplier, multiplier):
    if i * multiplier < userInput * multiplier:
        print(i, end = ", ")
    else:
        print(i)