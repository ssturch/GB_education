#Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
userInput = int(input("Введите число: "))
if userInput < 1 or userInput > 7: print("Данное число не является днем недели!")
elif userInput < 6: print("Это будний день!")
else: print("Это выходной день!")