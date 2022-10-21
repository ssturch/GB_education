
# import logger

# def ShowContacts(tempList):
#     if tempList != []:
#         # log = "ERROR: Selected contact list empty!"
#         # logger.saveToLog(log)
#         # logger.printLog(log)
#     for lib in tempList:
#         print(f"{list(lib.keys())[0][0]}", end = '. ')
#         for value in lib.values():
#             print(f"{value} ", end='')
#         print(end = "\n")

            
    
def AddContact(tempList, line):
    if line.replace(' ', '') == "": 
        # log = "ERROR: Added contact is empty"
        # logger.saveToLog(log)
        # logger.printLog(log)
        return tempList
    else:
        resDict = {}
        data = ["name", "patron", "surname", "tel"]
        if tempList == []: lastIter = -1
        else: lastIter = list(tempList[-1].keys())[-1][0]
        for iter, el in enumerate(line.split(" ", 3)):
          el = el.replace("\n","")
          resDict.update({(lastIter + 1,data[iter]): el})
        tempList.append(resDict)
        return tempList

def ChangeContact(tempList, n, p, s, t, number):
    try:
        tempList[number]
    except:
        # log = "ERROR: Сontact number does not exist. "
        # logger.saveToLog(log)
        # logger.printLog(log)
        return tempList

    data = {(number, "name"):n, (number, "patron"):p ,(number, "surname"):s, (number, "tel"):t}
    for key in data: 
        if data[key] != '': tempList[number].update({(number, key[1]): data[key]})  
    return tempList

def DeleteContact(tempList, number):
    try:
        tempList[number]
    except:
        # log = "ERROR: Сontact number does not exist. "
        # logger.saveToLog(log)
        # logger.printLog(log)
        return tempList

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

def FindContact(tempList, n, p, s, t):
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
