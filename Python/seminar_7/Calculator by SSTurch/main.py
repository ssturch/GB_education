import input_list
import input_check
import input_calc
import os
os.system('cls')
isOk = False
while isOk == False:
    print("Введите выражение для расчета: ")
    userInput = input()
    userEqua = input_list.UserInputSplit(userInput)
    if (input_check.UserInputCheckEqua(userEqua) and
        input_check.UserInputCheckParentheses(userEqua) == True): isOk = True
    else: print("Выражение ошибочное, введите его повторно:")
os.system('cls')
res = input_calc.CalcRes(userInput)
match res[0]:
    case "bool":
        if res[1] == False: print(f"{userInput} <= данное выражение является ложью!")
        if res[1] == True: print(f"{userInput} <= данное выражение является истиной!")
    case "dec":
        print(f"{userInput} = {res[1]}")
    case "txt":
        print(res[1])



