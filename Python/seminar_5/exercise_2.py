# Создайте программу для игры с конфетами человек против человека.
# Правила: На столе лежит 150 конфет. Играют два игрока, делая ход друг после друга. 
# Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет. 
# Все конфеты оппонента достаются сделавшему последний ход. Сколько конфет нужно взять первому игроку, 
# чтобы забрать все конфеты у своего конкурента?
# a) добавьте игру против бота
# b) подумайте как наделить бота 'интеллектом'

import random

qtySweet = 150

def players():
    global userName, botName
    userName = input('Введите Ваше имя: ')
    botName = 'Компьютер'
    return (userName, botName)

def logic(qtySweet):
    playersNames = players()
    i = random.randint(0,1)
    print(f'Первым ходит игрок: {playersNames[i]}.')
    while qtySweet > 0:
        if i == 1:
            if qtySweet < 29: move = qtySweet
            elif qtySweet < 56: move = 28
            else: move = random.randint(0, 28)
            
            if move == 0: (f'Компьютер пропустил ход!')
            else:
                print(f'Компьютер забрал {move} конфет!')
                qtySweet -= move
                i = 0
        else:
            move = int(input(f'{playersNames[0]}, возьмите конфеты: '))
            while move > 28:
                    print(f'Можно взять не более 28 конфет!')
                    move = int(input("Введи количество конфет снова: "))
            qtySweet -= move
            i = 1
        if qtySweet > 0: print(f'Осталось {qtySweet} конфет!')
        else: print('Конфеты кончились!'); winner = playersNames[abs(i-1)]
            
    return winner

finish = logic(qtySweet)

match finish:     
    case 'Компьютер':
        print(f"Ты проиграл, {userName}!") 
    case _:
        print(f"Это победа, {userName}!")
