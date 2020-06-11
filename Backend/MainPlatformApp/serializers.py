from abc import ABC

from rest_framework import serializers
import MainPlatformApp.models as models_mp
import MedievalBattleApp.models as models_mb


class UserSerializer(serializers.Serializer, ABC):
    userid = serializers.IntegerField()
    username = serializers.CharField(max_length=20)
    telegramid = serializers.CharField(max_length=20)
    discordid = serializers.CharField(max_length=20)