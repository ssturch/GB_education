# Напишите программу, удаляющую из текста все слова, содержащие ""абв"".
import re

userInputString = input("Введите строку для удаления слов: ")
userInputFind = input("Введите часть слова для поиска: ")

regEx = fr"(?=\s*)\w*(\{userInputFind})\w*(?=\s*)"
outputString = re.sub(regEx,'',userInputString)

print(f"Результат: {outputString}")
