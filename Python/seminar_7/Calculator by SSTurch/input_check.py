import re
#Проверка наличия сторонних элементов в списке
def UserInputCheckEqua(userInputList):
    opCort = ('+','*','/','^','(',')','=')
    checkSet = set(map(lambda simb: True if (simb in opCort or re.fullmatch(r'[-+]*\d*', simb) is not None) else None, userInputList))
    if None in checkSet: return False
    if True in checkSet: return True
    else: return False
#Проверка правильности расстановки скобок
def UserInputCheckParentheses(userInputList):
    isOk = True
    checkList = list(filter(lambda simb: True if (simb == ")" or simb == "(") else None, userInputList))
    counter = 0
    for simb in checkList:
        if simb == ")" and counter == 0: isOk = False; break
        if simb == "(" and counter == 0: counter += 1; continue
        if simb == ")" and counter > 0: counter -=1; continue 
        if simb == "(" and counter > 0: counter += 1; continue
    if counter != 0: isOk = False
    return isOk
