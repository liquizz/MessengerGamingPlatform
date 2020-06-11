from django.db import models

# Create your models here.


class User(models.Model):
    userid = models.AutoField(db_column='UserId', primary_key=True)
    username = models.CharField(db_column='UserName', max_length=20)
    telegramid = models.CharField(db_column='TelegramId', max_length=20)
    discordid = models.CharField(db_column='DiscordId', max_length=20)
    # TODO посмотреть точную длину telegramid и discordid


# class Session(models.Model):
#     sessionid = models.AutoField(db_column='SessionId', primary_key=True)
#     userid = models.ForeignKey(User, on_delete=models.CASCADE())
#     medievalbattleid = models.ForeignKey()
