#  Создайте программу для игры в 'Крестики-нолики'.

from re import I
from tkinter import *
import os



window = Tk()  
window.title("Крестики - нолики")  
window.geometry('318x318')
window.resizable(FALSE,FALSE)
zeroimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'zero.png')
crossimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'cross.png')
emptyimg = PhotoImage(file = os.path.abspath(__file__).replace(os.path.basename(__file__), '')+ r'empty.png')

def clicked(a,b):
    exec(f"btn{a}{b}.config(image=crossimg)")
    
for i in range(0,3):
    for j in range (0,3):
        exec('btn{0}{1} = Button(window, height=100, width=100, image = emptyimg, command=clicked({0},{1})); btn{0}{1}.grid(column={0}, row={1})'.format(i,j))



# btn11 = Button(window, height=100, width=100, image=zeroimg)

# if btn11.
# btn11.config(image=crossimg)


# btn11 = Button(window, height=100, width=100, image=zeroimg)
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