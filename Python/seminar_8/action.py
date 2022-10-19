
test = [ {(0, "name"): "Вася", (0, "patron"): "Буеракович", (0, "surname"): "Западлянский", (0, "tel"): "99969235"}, {(1, "name"): "Оля", (1, "patron"): "Тупакова", (1, "surname"): "Всепропалова", (1, "tel"): "622234"} ]

def ShowContacts(list):
    for lib in list:
        for value in lib.values():
            print(f"{value} ", end='')
        print(end = "\n")

def AddContact(tempList, line):
    resDict = {}
    data = ["name", "patron", "surname", "tel"]
    lastIter = list(tempList[-1].keys())[-1][0]
    for iter, el in enumerate(line.split(" ", 3)):
        el = el.replace("\n","")
        resDict.update({(lastIter,data[iter]): el})
    tempList.append(resDict)
    return tempList

def ChangeContact(tempList, n, p, s, t, number):
    data = {0:("name", n), 1:("patron",p), 2:("surname",s), 3:("tel",t)}
    #ДОДЕЛАТЬ!
    for key, value in data:
        if value[1] is not False: tempDict.update({(number,data[iter]): el})
    


ShowContacts(test)
print(AddContact(test,'Димка Петрович Замухрышкин 9293592395'))
ShowContacts(test)