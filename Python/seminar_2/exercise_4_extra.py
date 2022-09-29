# Реализуйте алгоритм перемешивания списка.
# Алгоритм реализован без shuffle

import random
userInput = str(input("Введите список путем введения строки, разделителем является пробел " ":\n"))
userInputArr = userInput.split()
shuffOutputArr = []
randI = None

for i in range (len(userInputArr) - 1, -1, -1):
    randI = random.randint(0, i)
    shuffOutputArr.append(userInputArr[randI])
    userInputArr.pop(randI)
    
print(f"Перемешанный список:\n{shuffOutputArr}")
