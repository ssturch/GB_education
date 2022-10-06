#Даны два файла, в каждом из которых находится запись многочлена.
#Задача - сформировать файл, содержащий сумму многочленов.

import re, os, math

def DigestionStrEquation(equa):
    if equa != None or '':
        regExp = r"([+-]*\d*x\^\d+)*([+-]\d*x?)?([+-]\d*)?=0$"
        check = re.fullmatch(regExp, equa, flags=0)
        if check == None: print ("Входящее выражение неверно!")
        else:
            regExpDegreeTerm = r"[+-]*\d*x\^\d+" # для поиска слагаемых с x и степенями"
            regExpDegreelessTerm = r"[+-]\d*x(?=[+-=])" # для поиска слагаемых с x
            resExpUnusualTerm = r"[+-]\d*(?=[=+-])" # для поиска простых слагаемых
            resExpDegreeTermDec = r"^\W?\d*(?=[\(x)])|(?<=\^)\d*$" # разложение степенных слагаемых
            regExpDegreelessTermDec = r"^\W?\d*(?=x)" # разложение слагаемых с x
            regList = [regExpDegreeTerm, regExpDegreelessTerm, resExpUnusualTerm] # список регулярных выражений
            termDict = {} # пустой словарь соответсвия совпадению
            for r in range(len(regList)):
                matches = re.findall(regList[r], equa)
                for m in range(len(matches)):
                    
                    if regList[r] == regExpDegreeTerm: 
                        decompose = re.findall(resExpDegreeTermDec, matches[m])
                        if decompose[0] == '' or decompose[0] == '+': decompose[0] = 1
                        if decompose[0] == '-': decompose[0] = -1
                        termDict[decompose[1]] = int(decompose[0])
                    
                    if regList[r] == regExpDegreelessTerm: 
                        decompose = re.findall(regExpDegreelessTermDec, matches[m])
                        if decompose != None:
                            if decompose[0] == '' or decompose[0] == '+': decompose[0] = 1
                            if decompose[0] == '-': decompose[0] = -1
                            termDict["dlt"] = int(decompose[0])
                        else: termDict["dlt"] = 0
                        
                    if regList[r] == resExpUnusualTerm: 
                        termDict["ut"] = int(matches[m])
        return termDict   
    else:
        return print("ERROR")          

def DictEquaSumm(dictEqua1, dictEqua2):
    if len(dictEqua1) and len(dictEqua2) == 0: return print("ERROR")
    else:
        dictResult = {}
        for key, value in dictEqua1.items():
            try:
                dictResult[key] = value + dictEqua2[key]
            except:
                dictResult[key] = value
        for key, value in dictEqua2.items():
            dictResult.setdefault(key, value)
    return dictResult

def EquaFromDict(dictEqua):
    outputStr = ''
    itFirstTerm = True
    for key, value in dictEqua.items():
        sign = ''
        if int(value) > 0 and itFirstTerm == True: itFirstTerm = False
        elif int(value) > 0 and itFirstTerm == False: sign = '+'
        if key.isdigit(): 
            if int(value) > 1 or int(value) < -1: outputStr += sign + str(value) + 'x^' + key
            if abs(int(value)) == 1:
                if int(value) == -1: outputStr += '-x^' + key
                elif itFirstTerm == True: outputStr += 'x^' + key
                else: outputStr += sign + 'x^' + key
        if key == "dlt":
            if int(value) > 1 or int(value) < -1: outputStr += sign + str(value) + 'x'
            if abs(int(value)) == 1:
                if int(value) == -1: outputStr += '-x'
                elif itFirstTerm == True: outputStr += 'x' 
                else: outputStr += sign + 'x'
        if key == "ut": outputStr += sign + str(value)
    outputStr += '=0'
    return outputStr

def WriteToFile(path,txt):
    file = open(path, 'w')
    file.write(txt)
    file.close

def ReadFromFile(path):
    file = open(path, 'r')
    result = file.readline()
    return result
         
pathEqua1 = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\equa_ex5_1.eq'
pathEqua2 = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\equa_ex5_2.eq'
writeTo = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'\equa_ex5_RESULT.eq'
equa1 = ReadFromFile(pathEqua1)
print(f"Получено 1-ое уравнение: {equa1}")
equa2 = ReadFromFile(pathEqua2)
print(f"Получено 2-ое уравнение: {equa2}")
tempResult = DictEquaSumm(DigestionStrEquation(equa1), DigestionStrEquation(equa2))
result = EquaFromDict(tempResult)
print(f"Результат сложения: {result}")
try:
    WriteToFile(writeTo,result)
    print (f"Результат сложения записан в файл equa_ex5_RESULT.eq")
except:
    print ("Ошибка записи!")

