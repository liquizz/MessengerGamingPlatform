from rest_framework import serializers


class UnitClassesSerializer(serializers.Serializer):
    classid = serializers.IntegerField()
    classname = serializers.CharField()
    classdescription = serializers.CharField()
    starthealpoints = serializers.IntegerField()
    startdefencepoints = serializers.IntegerField()
    attackrange = serializers.FloatField()  # Возможно нужно использовать Int?
    attackcooldown = serializers.FloatField()


class PlayerSerializer(serializers.Serializer):
    sessionid = serializers.IntegerField()


class SessionMedievalBattleSerializer(serializers.Serializer):
    userid = serializers.IntegerField()


class MapPositionsSerializer(serializers.Serializer):
    positionid = serializers.IntegerField()
    playerid = serializers.IntegerField()


class UnitSerializer(serializers.Serializer):
    unitid = serializers.IntegerField()
    unitcustomname = serializers.CharField()
    unitclassid = serializers.IntegerField()
    unitcurrhp = serializers.IntegerField()
    unitcurrdp = serializers.IntegerField()
    positionid = serializers.IntegerField()


class PositionSerializer(serializers.Serializer):
    positionid = serializers.IntegerField()
    position = serializers.IntegerField()
    mappositionsid = serializers.IntegerField()
