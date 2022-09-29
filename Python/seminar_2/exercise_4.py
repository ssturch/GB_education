# Реализуйте алгоритм перемешивания списка.
# Это можно считать реализацией алгоритма, чтобы не изобретать велосипед?)

import random
userInput = str(input("Введите список путем введения строки, разделителем является пробел " ":\n"))
userInputArr = userInput.split()
random.shuffle(userInputArr)
print(f"Перемешанный список:\n{userInputArr}")
