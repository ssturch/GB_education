from PyQt5.QtWidgets import QApplication
from PyQt5 import uic
import os, sys
import action, file

global path
global contList, contRaw, undoList
global onlyItem, number, name, patron, surname, tel

contList = []
contRaw = []
tempRaw = []
path = ''
number = ''

def click_OpenFile():
    global path, contRaw, contList, undoList 
    path = file.OpenFile()
    if path != None: 
        contRaw = file.OpenContacts(path)[1]
        contList = file.ConvertToFile(contRaw)
        undoList = contList    
        Window.listWidget.clear()
        Window.listWidget.addItems(contList)
        return path
    else: path = ''

def click_SaveFile():
    global path
    if path !='': file.SaveContacts(path, contList)
    else: click_SaveTo()

def click_SaveTo():
    global path, contRaw, contList, undoList 
    path = file.OpenFile()
    if path != None: file.SaveContacts(path, contList)
    else: path = ''


def click_Contact(item):
    global onlyItem, number, name, patron, surname, tel
    onlyItem = item.text()
    number = Window.listWidget.currentRow()
    tempList = onlyItem .split()
    Window.NumberLabel.setText(str(number))
    Window.NameEdit.setText(tempList[0])
    Window.PatronEdit.setText(tempList[1])
    Window.SurnameEdit.setText(tempList[2])
    Window.TelEdit.setText(tempList[3])
    name = Window.NameEdit.text()
    patron = Window.PatronEdit.text()
    surname = Window.SurnameEdit.text()
    tel = Window.TelEdit.text()

def click_Add():
    global contList, contRaw, undoList
    name = Window.NameEdit.text()
    patron = Window.PatronEdit.text()
    surname = Window.SurnameEdit.text()
    tel = Window.TelEdit.text()
    onlyItem = name+' '+patron+' '+surname+' '+tel+' '
    undoList = contList
    contRaw = action.AddContact(contRaw, onlyItem)
    contList = file.ConvertToFile(contRaw)
    Window.listWidget.clear()
    Window.listWidget.addItems(contList)

def click_Find():
    global contList, contRaw, undoList
    name = Window.NameEdit.text()
    patron = Window.PatronEdit.text()
    surname = Window.SurnameEdit.text()
    tel = Window.TelEdit.text()
    undoList = contList
    findRaw = action.FindContact(contRaw, name, patron, surname, tel)
    findList = file.ConvertToFile(findRaw)
    contList = findList
    Window.listWidget.clear()
    Window.listWidget.addItems(contList)

def click_Change():
    global contList, contRaw, undoList
    name = Window.NameEdit.text()
    patron = Window.PatronEdit.text()
    surname = Window.SurnameEdit.text()
    tel = Window.TelEdit.text()
    undoList = contList
    contRaw = action.ChangeContact(contRaw, name, patron, surname, tel, number)
    contList = file.ConvertToFile(contRaw)
    Window.listWidget.clear()
    Window.listWidget.addItems(contList)

def click_Delete():
    global contList, contRaw, undoList, number
    undoList = contList
    if number != '': 
        contRaw = action.DeleteContact(contRaw, number)
        contList = file.ConvertToFile(contRaw)
        number = ''
        Window.listWidget.clear()
        Window.listWidget.addItems(contList)

def click_Undo():
    global contList, undoList, contRaw
    contList = undoList
    contRaw = file.ConvertFromFile(contList)
    undoList = []
    Window.listWidget.clear()
    Window.listWidget.addItems(contList)







 
app = QApplication(sys.argv)
Window = uic.loadUi((os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r"\mainUI.ui"))
Window.show()

Window.LoadListButton.clicked.connect(click_OpenFile)
Window.SaveListButton.clicked.connect(click_SaveFile)
Window.SaveToButton.clicked.connect(click_SaveTo)
Window.listWidget.itemActivated.connect(click_Contact)
Window.AddButton.clicked.connect(click_Add)
Window.FindButton.clicked.connect(click_Find)
Window.ChangeButton.clicked.connect(click_Change)
Window.DeleteButton.clicked.connect(click_Delete)
Window.UndoButton.clicked.connect(click_Undo)

sys.exit(app.exec())



