import os

def OpenContacts(path):
    isError = False
    try:
        file = open(path, 'r')
        lineList = file.readlines()
        file.close()
        return (isError, ConvertFromFile(lineList), "Чтение файла успешно!")
    except Exception as e:
        isError = True
        return (isError, None, f"Ошибка: {e.__class__.__name__}")

def SaveContacts(path, saveList):
    isNewFile = True
    try:
        file = open(path, 'x')
        print(isNewFile)
    except FileExistsError:
        isNewFile = False
        print(isNewFile)
        file = open(path, 'a')
    file.writelines(saveList)
    file.close()
    if isNewFile  is True: return (isNewFile, None, f"Предупреждение: Создан новый файл {path}")
    if isNewFile is False: return(isNewFile, None, "Запись в файл успешна!")
    
def ConvertFromFile(tempList):
    resList = []
    resDict = {}
    data = ["name", "patron", "surname", "tel"]
    for iter1, line in enumerate(tempList):
        for iter2, el in enumerate(line.split(" ", 3)):
            el = el.replace("\n","")
            resDict.update({(iter1,data[iter2]): el})
        resList.append(resDict)
        resDict = {}
    return resList

def ConvertToFile(tempList):
    resList = []
    for dict in tempList:
        res =' '.join(dict.values()) + '\n'
        resList.append(res)
    return resList


pathTest = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\test.contfile'
pathSaveTest =  os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\testS606ave.contfile'

testSave = ConvertToFile(OpenContacts(pathTest)[1])
print(SaveContacts(pathSaveTest, testSave))
