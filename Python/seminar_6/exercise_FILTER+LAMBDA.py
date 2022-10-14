# Напишите программу, удаляющую из текста все слова, содержащие ""абв"".

userInputString = input("Введите строку для удаления слов: ")
userInputFind = input("Введите часть слова для поиска: ")

res = ' '.join(list(filter(lambda x: True if x.find(userInputFind) == -1 else False, userInputString.split())))
# regEx = fr"(?=\s*)\w*(\{userInputFind})\w*(?=\s*)"
# outputString = re.sub(regEx,'',userInputString)

print(f"Результат: {res}")
