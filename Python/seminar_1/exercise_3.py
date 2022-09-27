#Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 5 и 10 или 15, но не 30.
userInput = int(input("Введите число: "))
if userInput % 5 == 0 and userInput % 10 == 0 and userInput % 30 != 0: print(f"Число {userInput} кратно 5 и 10 и не кратно 30.")
elif userInput % 15 == 0 and userInput % 30 != 0 : print(f"Число {userInput} кратно 15 и не кратно 30.")
else: print(f"Число {userInput} не удовлетворяет поставленному условию.")