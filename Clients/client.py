from telebot import types
from random import randint
from array import *
import telebot
import config
import requests
import os
import time

bot = telebot.TeleBot(config.token)

keyboard_throw = types.ReplyKeyboardMarkup(one_time_keyboard=False, resize_keyboard=True)
keyboard_throw.row('Кинуть кости {}'.format(config.dice))
keyboard_choice = types.ReplyKeyboardMarkup(one_time_keyboard=False, resize_keyboard=True)
keyboard_choice.row('Поиск Сессии', 'Ready', '/shutdown')


@bot.message_handler(commands=['start'])
def st_message(message):
    bot.send_message(message.chat.id, 'Бот Начал Работу', reply_markup=keyboard_choice)
    print(message.chat.first_name)


@bot.message_handler(commands=['shutdown'])
def shutdown(message):
    bot.send_message(message.chat.id, 'Бот Закончил Работу')
    bot.stop_polling()


@bot.message_handler(commands=['debug'])
def debug(message):
    print('тут нихуя нет, идите нахуй')


@bot.message_handler(content_types=['text'])
def send_text(message):
    if message.text == 'Поиск Сессии' or message.text == 'поиск сессии':
        bot.send_message(message.chat.id, 'Поиск сесии запущен')
        bot.send_message(message.chat.id, message.from_user.id)
    elif message.text.lower() == 'поиск сессии' or  message.text.lower() == 'поиск сесии':
        bot.send_message(message.chat.id, 'Вот ты конченый')
    print(message.from_user.id)
    response = requests.get('http://localhost:51198/api/Users/CreateTelegramUser?Username=name&TelegramId=' + str(message.from_user.id))
    print(str(message.from_user.id))
    print(response)
    print(response.content)
    response = requests.get('http://localhost:51198/api/Users/GetUserByTelegram?telegramid=' + str(message.from_user.id))
    print(response)
    print(response.content)





"""
def send_text(message):
    bigger = False
    print(message.text, message.chat.first_name)
    if message.text.lower() == 'больше':
        bigger = True
    elif message.text.lower() == 'меньше':
        bigger = False
    # elif message.text.lower() == 'равно':
        
    elif message.text.lower() == 'кинуть кости {}'.format(config.dice):
        rnd = randint(1, 6)
        bot.send_message(message.chat.id, config.dices[rnd])
        rnd1 = randint(1, 100)
        if bigger:
            if rnd1 >= 20:
                rndr = randint(1, rnd)
                bot.send_message(message.chat.id, rndr)
"""

bot.polling()