#Здесь создается бот и хранится его токен

from aiogram import Bot
from aiogram.dispatcher import Dispatcher
from aiogram.utils import executor


bot = Bot(token='5770454263:AAE56AkX2LG5MivJMWl4X-D0vvHackxqrQ4')
dp = Dispatcher(bot)

if __name__ == '__main__':
    executor.start_polling(dp)