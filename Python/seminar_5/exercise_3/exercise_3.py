#  Создайте программу для игры в 'Крестики-нолики'.


from itertools import count
from tkinter import *
import os, random, winsound, time

window = Tk()  
window.title("Крестики - нолики")  
window.geometry('318x358')
window.resizable(FALSE,FALSE)
scriptPlace = str(os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'exercise_3.py')
zeroimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'zero.png')
crossimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'cross.png')
emptyimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'empty.png')
clickSound1 = str(os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'a.wav')
clickSound2 = str(os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'b.wav')
clickSound3 = str(os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'c.wav')
winSound = str(os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'winner.wav')
looseSound = str(os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'looser.wav')
drawSound = str(os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'itsdraw.wav')
clickList = [clickSound1, clickSound2, clickSound3]

butDict = {}
butList = ['btn00','btn01','btn02','btn10','btn11','btn12','btn20','btn21','btn22']
isUserCourse = True
сounter = 0

def changePic(button, pic):
    button.config(image = pic)

def playSound(type):
    match type:
        case 'random':
            soundChoose = random.randint(0, len(clickList)-1)
            winsound.PlaySound(clickList[soundChoose], winsound.SND_FILENAME | winsound.SND_ASYNC)
        case 'win':
            winsound.PlaySound(winSound, winsound.SND_FILENAME | winsound.SND_ASYNC)
        case 'loose':
            winsound.PlaySound(looseSound, winsound.SND_FILENAME | winsound.SND_ASYNC)
        case 'draw': 
            winsound.PlaySound(drawSound, winsound.SND_FILENAME | winsound.SND_ASYNC)

def checkWin(butDict):
    global сounter
    actualSet = set(butDict.values())
    boolList = [True,False]
    stop = False
    stopSet = set()
    for a in boolList:
        if stop == False:
            winSet1 = {(0, a), (1, a), (2, a)}
            winSet2 = {(3, a), (4, a), (5, a)}
            winSet3 = {(6, a), (7, a), (8, a)}
            winSet4 = {(0, a), (3, a), (6, a)}
            winSet5 = {(1, a), (4, a), (7, a)}
            winSet6 = {(2, a), (5, a), (8, a)}
            winSet7 = {(0, a), (4, a), (8, a)}
            winSet8 = {(2, a), (4, a), (6, a)}
            winSetList = [winSet1, winSet2, winSet3, winSet4, winSet5, winSet6, winSet7, winSet8]

            for sets in winSetList:
                if sets == actualSet.intersection(sets): 
                    for btns in sets:
                            for k, v in butDict.items():
                                if v == btns:
                                    stopBtns = (k,) + btns
                                    stopSet.add(stopBtns)
                    stop = True 
                    break
        else: break

    if stop == True:
        for btn in stopSet:
            BtnObject = eval(btn[0])
            BtnObject.config(bg = 'red')
            if btn[2] == True: playSound('win')
            if btn[2] == False: playSound('loose')
            BlockButtons()
    if сounter == 9:
        BlockButtons()
    return stop

def BlockButtons():
    global butList
    butList = ['btn00','btn01','btn02','btn10','btn11','btn12','btn20','btn21','btn22']
    for btn in butList:
        BtnObject = eval(btn)
        BtnObject.config(command = lambda:None)

def ResetGame():
    global butDict
    global butList
    global isUserCourse
    global сounter

    butList = ['btn00','btn01','btn02','btn10','btn11','btn12','btn20','btn21','btn22']
    butDict = {}
    isUserCourse = True
    сounter = 0

    btn00.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn00, 0))
    btn01.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn01, 1))
    btn02.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn02, 2))
    btn10.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn10, 3))
    btn11.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn11, 4))
    btn12.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn12, 5))
    btn20.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn20, 6))
    btn21.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn21, 7))
    btn22.config(image = emptyimg, bg = '#f0f0f0',command = lambda:clicked(btn22, 8))

def clicked(BtnName, pos):
    
    global сounter 
    global butDict
    global isUserCourse
    BtnObject = BtnName
    BtnNameStr = butList[pos]

    if isUserCourse == True and BtnNameStr != None:
        butDict.update({BtnNameStr:(pos, isUserCourse)})
        butList[pos] = None
        changePic(BtnObject, zeroimg)

        сounter += 1
        isUserCourse = False
        playSound('random')
        if сounter < 9: clickedByBot()

    elif isUserCourse == False:
        changePic(BtnObject, crossimg)
        isUserCourse = True
    print(сounter)
    checkWin(butDict)
    
def clickedByBot():
    global сounter 
    global butDict
    global isUserCourse

    while True:
        botChoise = random.randint(0, len(butList) - 1)
        if butList[botChoise] != None: break

    BotBtnName = butList[botChoise]
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
resetBtn = Button(window, height=2, width=13,  text = 'RESET', command = ResetGame)
resetBtn.grid(column=1, row=3)

window.mainloop()

