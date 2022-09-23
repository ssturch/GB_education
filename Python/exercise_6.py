#Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
# в которой находится эта точка (или на какой оси она находится).

#! Постановка задачи странная, зачем примечание в скобках, если X ≠ 0 и Y ≠ 0?
 
userInputX = int(input("Введите X: "))
userInputY = int(input("Введите Y: "))
if userInputX == 0 or userInputY == 0: print("Координаты должны соответствовать условию X ≠ 0 и Y ≠ 0!")
else:
    if userInputX > 0 and userInputY > 0: print("Данные координаты относятся к I четверти.")
    if userInputX < 0 and userInputY > 0: print("Данные координаты относятся к II четверти.")
    if userInputX < 0 and userInputY < 0: print("Данные координаты относятся к III четверти.")
    if userInputX > 0 and userInputY < 0: print("Данные координаты относятся к IV четверти.")