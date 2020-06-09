from rest_framework import serializers
import MainPlatformApp.models as models_mp
import MedievalBattleApp.models as models_mb


class CreateGameSerializer(serializers.Serializer):
    id = serializers.IntegerField()