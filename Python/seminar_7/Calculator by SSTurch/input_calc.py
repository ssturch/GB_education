
def CalcRes(userInput):
    equa = userInput.replace("^","**")
    if "=" not in equa:
        try: 
            a = eval(equa)
            return ('dec', a)
        except ZeroDivisionError:
            return ('txt', "Делить на ноль нельзя!")
    if "=" in equa:
        equa = equa.replace("=","==")
        try:
            boole = eval(equa)
            if boole is True: return ('bool', True) 
            else: return ('bool',False)
        except:
            return ('txt', "Ошибка ввода!")
    
    
    

    
            
            

