#Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

userInputX = input("Введите X: ")
userInputY = input("Введите Y: ")
userInputZ = input("Введите Z: ")

leftPart = not (userInputX or userInputY or userInputZ)
rightPart = not userInputX and not userInputY and not userInputZ
statement = leftPart == rightPart

if statement != True: print(f"Утверждение ложно!")
else: print(f"Утверждение истинно")