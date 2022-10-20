


test = [ {(0, "name"): "Вася", (0, "patron"): "Буеракович", (0, "surname"): "Западлянский", (0, "tel"): "99969235"}, {(1, "name"): "Оля", (1, "patron"): "Тупакова", (1, "surname"): "Всепропалова", (1, "tel"): "622234"} ]

def ShowContacts(tempList):
    for lib in tempList:
        print(f"{list(lib.keys())[0][0]}", end = '. ')
        for value in lib.values():
            print(f"{value} ", end='')
        print(end = "\n")

def AddContact(tempList, line):
    resDict = {}
    data = ["name", "patron", "surname", "tel"]
    lastIter = list(tempList[-1].keys())[-1][0]
    for iter, el in enumerate(line.split(" ", 3)):
        el = el.replace("\n","")
        resDict.update({(lastIter + 1,data[iter]): el})
    tempList.append(resDict)
    return tempList

def ChangeContact(tempList, n, p, s, t, number):
    try:
        tempList[number]
    except:
        return None 

    data = {(number, "name"):n, (number, "patron"):p ,(number, "surname"):s, (number, "tel"):t}
    for key in data: 
        if data[key] != '': tempList[number].update({(number, key[1]): data[key]})  
    return tempList

def DeleteContact(tempList, number):
    try:
        tempList[number]
    except:
        return None 
    tempList.pop(number)
    return RemakeContactNumbering(tempList)

def RemakeContactNumbering(tempList):
    i = 0
    for el in tempList:
        tempEl = {}
        for key in el:
            tempValue = el[key]
            tempKey = (i, key[1])
            tempEl.update({tempKey: tempValue})
        el = {}
        tempList[i] = tempEl
        i += 1
    return tempList

def FindContact(tempList, n, p, s, t,):
    srchList = []
    data = {"name":n, "patron":p, "surname":s, "tel":t}
    i = 0
    for el in tempList:
        for key in data:
            if el[(i, key)] == data[key]: 
                srchList.append(el)
                break
        i += 1

    return srchList



ShowContacts(test)
print(AddContact(test,'Димка Петрович Замухрышкин 9293592395'))
print(test)
ChangeContact(test, "Дима", '', "Иванов", "", 2)
DeleteContact(test, 0)
ShowContacts(test)
src = FindContact(test, "Ивав", '','','')
ShowContacts(src)