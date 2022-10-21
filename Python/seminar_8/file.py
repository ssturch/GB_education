import easygui
def OpenFile():
    path = easygui.fileopenbox()
    return path

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
    except FileExistsError:
        isNewFile = False
        file = open(path, 'w')
    saveList = list(map(lambda el: el + '\n', saveList))
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
        res =' '.join(dict.values()) #+ '\n'
        resList.append(res)
    return resList
