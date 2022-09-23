#Напишите программу, которая будет принимать на вход дробь и показывать первую цифру дробной части числа.
print("Введите дробное число:", end = " "); userInput = input()
if isinstance(userInput, float): print(f"Результат: {str(userInput)[3]}")
else: print(f"Число {userInput} не является дробным!")