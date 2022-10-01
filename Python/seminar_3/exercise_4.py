# Напишите программу, которая будет преобразовывать десятичное число в двоичное
# Вообще есть уже встроенная функция bin, но подозреваю, что алгоритм нужно самому продумать)

userInput = int(input("Введите число: "))
# print(f"Число {userInput} в двоичной системе это {bin(userInput)}") # Использование встроенной функции
result = ""
tempDigit = userInput
while tempDigit > 0:
    result = str(tempDigit % 2) + result
    tempDigit = tempDigit // 2

print(f"Число {userInput} в двоичной системе это {result}")