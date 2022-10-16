import re

def UserInputSplit(userInput):  #Разделение ввода пользователя на список
    return re.split(r'\s*([-+\*\/\^\(\)\=])\s*', userInput) 