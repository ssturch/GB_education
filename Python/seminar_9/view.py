# юда все функции отправляющие сообщения


from aiogram import types
from aiogram.dispatcher.filters.state import State
from bot import bot
import model, time


async def greetings(message: types.Message):
    await bot.send_message(message.from_user.id,
                           f'{message.from_user.first_name}, привет!\n'
                           f'Это игра в конфетки.\n'
                           f'Всего есть 150 конфет, выиграет тот кто заберет все конфеты!\n'
                           f'Знай! Взять можно не более 28 конфеток!')

async def goodbye(message: types.Message):
    await bot.send_message(message.from_user.id,
                           f'{message.from_user.first_name}, ты думаешь мы закончили? Я сложил все конфеты обратно!\n'
                           f'Давай еще играть! Бери конфеты!')

async def botTurn(message: types.Message):
    if model.bot_qty == 0:
        await bot.send_message(message.from_user.id,f'Я пропустил ход!')
    else: await bot.send_message(message.from_user.id,f'Я взял {model.bot_qty} конфет!')
    
async def checkUserInput(message: types.Message, errType):
    match errType:
        case 0:
            await bot.send_message(message.from_user.id, 'Ах, ты грязный читер, говорил же, не более 28 конфеток!')
        case 1:
           await bot.send_message(message.from_user.id, 'Ну просил же, введи число!(((')

async def orderText(message: types.Message):
    if model.order == 1:
        await bot.send_message(message.from_user.id, 'Первый хожу я!')
    else: await bot.send_message(message.from_user.id, 'Первый ходишь ты!\nВведи количество конфет!')

async def sweetyCountText(message: types.Message):
    await bot.send_message(message.from_user.id,f'Осталось {model.total_count} конфет...')

async def inputSweetiesCount(message: types.Message):
    await bot.send_message(message.from_user.id,f'Введи количество конфет!')

async def noMoreSweeties(message: types.Message):
    await bot.send_message(message.from_user.id,f'Не осталось больше конфет(((')

async def isWinner(message: types.Message, whoWin):
    match whoWin:
        case "USER":
            await bot.send_message(message.from_user.id, f"Ура, ты победил!")
            await goodbye(message)  
            model.total_count = 150
            
            
        case "BOT":
            await bot.send_message(message.from_user.id, f"Фу, ты проиграл!")
            await goodbye(message)
            model.total_count = 150 
            

