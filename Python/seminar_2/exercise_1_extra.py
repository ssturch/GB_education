#Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр. (Вариант без float)
userInput = input("Введите число: ")
result = 0
for i in range (len(str(userInput))):
    if str(userInput)[i].isdigit(): result += int(str(userInput)[i])
print(f"Сумма цифр в числе = {result}")

