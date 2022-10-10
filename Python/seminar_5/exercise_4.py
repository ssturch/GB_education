#Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных. Входные и выходные данные хранятся в отдельных текстовых файлах.
import os, re

def WriteToFile(path,txt):
    try:
        file = open(path, 'w')
        file.write(txt)
        file.close
        print (f"Результат записан, путь к файлу: {path}")
    except:
        print ("Ошибка записи!")

def ReadFromFile(path):
    try:
        file = open(path, 'r')
        result = file.readline()
        result.replace('/n','')
        return result
    except:
        print ("Ошибка чтения!")


def rleCompress(inputString):
    regEx = r"(?=(.))\1{1,}"
    tempList = []
    matches = re.finditer(regEx, inputString)
    rleString = ''

    for matchNum, match in enumerate(matches, start = 1):
        tempList.append(match.group())

    for word in enumerate(tempList):
        for simbol in word[1]:
            rleString += str(len(word[1])) + simbol
            break
    return rleString

def rleUnbox(rleString):
    regEx = r"(\d+(?=\D))(\D+(?=\d*))"
    outputString = ''
    matches = re.findall(regEx, rleString)
    for cortege in matches:
        outputString += int(cortege[0]) * str(cortege[1])

    return outputString


pathCompressed = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\rle_ex4_compressed.rle'
pathDecompressed = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\rle_ex4_decompressed.rle'

isError = True
while isError == True:
    inputUser = input("Вы хотите сжать строку или распаковать ее? Введите P для сжатия или U для распаковки: ")
    if inputUser == "U" or inputUser == "P": isError = False
    else: inputUser = input("Ошибка ввода! Повторите ввод (P/U): ")

if inputUser == "U":
    rleString = ReadFromFile(pathCompressed)
    print(f"Получено выражение: {rleString}")
    result = rleUnbox(rleString)
    print(f"Результат распаковки: {result}")
    WriteToFile(pathDecompressed, result)

if inputUser == "P":
    origString = ReadFromFile(pathDecompressed)
    print(f"Получено выражение: {origString}")
    result = rleCompress(origString)
    print(f"Результат сжатия: {result}")
    WriteToFile(pathCompressed, result)

