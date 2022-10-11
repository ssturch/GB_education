#  Создайте программу для игры в 'Крестики-нолики'.


from tkinter import *
import os, random


window = Tk()  
window.title("Крестики - нолики")  
window.geometry('318x318')
window.resizable(FALSE,FALSE)

zeroimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'zero.png')
crossimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'cross.png')
emptyimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'empty.png')

butDict = {}
butList = ['btn00','btn01','btn02','btn10','btn11','btn12','btn20','btn21','btn22']
isUserCourse = True
сounter = 0

def changePic(button, pic):
    button.config(image = pic)

def checkWin(butDict):
    actualSet = set(butDict.values())
    boolList = [True,False]
    stop = False
    for a in boolList:
        if stop == False:
            winSet1 = {(0, a), (1, a), (2, a)}
            winSet2 = {(3, a), (4, a), (5, a)}
            winSet3 = {(6, a), (7, a), (8, a)}
            winSet4 = {(0, a), (3, a), (6, a)}
            winSet5 = {(1, a), (4, a), (7, a)}
            winSet6 = {(2, a), (5, a), (9, a)}
            winSet7 = {(0, a), (4, a), (9, a)}
            winSet7 = {(2, a), (4, a), (6, a)}
            winSetList = [winSet1, winSet2, winSet3, winSet4, winSet5, winSet6, winSet7]

            for sets in winSetList:
                print(actualSet.intersection(sets))
                if sets == actualSet.intersection(sets): 
                    print("ВЫИГРАЛ!")
                    stop = True 
                    break
        else: break


def clicked(BtnName, pos):
    global сounter 
    global butDict
    global isUserCourse
    BtnObject = BtnName
    BtnNameStr = butList[pos]
    print(f"{BtnNameStr} ПОЛЬЗ")
    if isUserCourse == True and BtnNameStr != None:
        butDict.update({BtnNameStr:(pos, isUserCourse)})
        butList[pos] = None
        changePic(BtnObject, zeroimg)
            # BtnObject.config(state = DISABLED)
        сounter += 1
        isUserCourse = False
            
        clickedByBot()

    elif isUserCourse == False:
        changePic(BtnObject, crossimg)
        isUserCourse = True

    checkWin(butDict)



    

def clickedByBot():
    global сounter 
    global butDict
    global isUserCourse

    while True:
        botChoise = random.randint(0, len(butList) - 1)
        if butList[botChoise] != None: break

    BotBtnName = butList[botChoise]
    print (f"{BotBtnName} БОТ")
    butDict.update({BotBtnName:(botChoise, isUserCourse)})
    butList[botChoise] = None
    BtnObject = eval(BotBtnName)
    BtnObject.invoke()
    сounter += 1

btn00 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn00, 0)); 
btn00.grid(column=0, row=0)
btn01 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn01, 1)); 
btn01.grid(column=0, row=1)
btn02 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn02, 2)); 
btn02.grid(column=0, row=2)
btn10 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn10, 3)); 
btn10.grid(column=1, row=0)
btn11 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn11, 4)); 
btn11.grid(column=1, row=1)
btn12 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn12, 5)); 
btn12.grid(column=1, row=2)
btn20 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn20, 6)); 
btn20.grid(column=2, row=0)
btn21 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn21, 7)); 
btn21.grid(column=2, row=1)
btn22 = Button(window, height=100, width=100, image = emptyimg, command = lambda:clicked(btn22, 8)); 
btn22.grid(column=2, row=2)


    #     BotBtnName = butList[botChoise]
    #     butDict.update(BotBtnName = (botChoise, isUserCourse))
    #     butList.remove(BotBtnName)
    #     print(eval(BotBtnName))
    #     changePic(eval(BotBtnName), crossimg)
    #     isUserCourse = True
    #     сounter += 1




# btn01.configure
# btn00.bind('<Button-1>', lambda pic = crossimg: ChangePic(pic))    

# # for i in range(0,3):
# #     for j in range (0,3):
#         exec("btn{0}{1}.config(comm=crossimg)".format(i,j))




# btn11 = Button(window, height=100, width=100, image=zeroimg)

# btn11.config(image=crossimg)
# btn11.grid(column=0, row=0)
# btn12 = Button(window, height=100, width=100, image=zeroimg)
# btn12.grid(column=1, row=0)
# btn13 = Button(window, height=100, width=100, image=zeroimg)
# btn13.grid(column=2, row=0)

# btn21 = Button(window, height=100, width=100, image=zeroimg)
# btn21.grid(column=0, row=1)
# btn22 = Button(window, height=100, width=100, image=zeroimg)
# btn22.grid(column=1, row=1)
# btn23 = Button(window, height=100, width=100, image=zeroimg)
# btn23.grid(column=2, row=1)

# btn31 = Button(window, height=100, width=100, image=zeroimg)
# btn31.grid(column=0, row=2)
# btn32 = Button(window, height=100, width=100, image=zeroimg)
# btn32.grid(column=1, row=2)
# btn33 = Button(window, height=100, width=100, image=zeroimg)
# btn33.grid(column=2, row=2)

window.mainloop()