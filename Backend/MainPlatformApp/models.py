from django.db import models

# Create your models here.


class User(models.Model):
    userid = models.AutoField(db_column='UserId', primary_key=True)
    username = models.TextField(db_column='UserName')
    telegramid = models.TextField(db_column='TelegramId')
    discordid = models.TextField(db_column='DiscordId')


# class Session(models.Model):
#     sessionid = models.AutoField(db_column='SessionId', primary_key=True)
#     userid = models.ForeignKey(User, on_delete=models.CASCADE())
#     medievalbattleid = models.ForeignKey()
