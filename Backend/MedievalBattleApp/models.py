from django.db import models
import MainPlatformApp.models as models_mp


# Create your models here.
# Здесь везде использую каскадное удаление принадлежащих элементов, TODO оптимизировать

class UnitClasses(models.Model):
    unitclassid = models.AutoField(db_column='UnitClassId', primary_key=True, unique=True)
    unitclassname = models.CharField(db_column='UnitClassName', max_length=30)
    unitclassdescription = models.TextField(db_column='UnitClassDescription')
    unitstarthealpoints = models.IntegerField(db_column='UnitStartHealPoints')
    unitstartdefencepoints = models.IntegerField(db_column='UnitStartDefencePoints')
    unitattackrange = models.IntegerField(db_column='UnitAttackRange')
    unitattackcooldown = models.FloatField(db_column='UnitAttackCooldown')  # Здесь выбрал флоат, так как это секунды.


class SessionMedievalBattle(models.Model):
    sessionid = models.AutoField(db_column='SessionId', primary_key=True)
    status = models.IntegerField() # 1 - открыта, 2 - закрыта


class Player(models.Model):
    sessionid = models.ForeignKey(SessionMedievalBattle, on_delete=models.CASCADE, default=None)
    userid = models.ForeignKey(models_mp.User, on_delete=models.CASCADE)  # проста
    # Возможно не нужно TODO упростить, или подумать над удалением


class MapPositions(models.Model):
    mappositionsid = models.AutoField(db_column='MapPositionsId', primary_key=True)
    playerid = models.ForeignKey(Player, on_delete=models.CASCADE, default=None)


class Unit(models.Model):
    unitid = models.AutoField(primary_key=True, db_column='UnitId')
    unitcustomname = models.CharField(db_column='UnitCustomName', max_length=30)
    unitclassid = models.ForeignKey(UnitClasses, on_delete=models.CASCADE)
    unitcurrhp = models.IntegerField(db_column='UnitCurrentHealPoints')
    unitcurrdp = models.IntegerField(db_column='UnitCurrentDefencePoints')
    mappositionsid = models.ForeignKey(MapPositions, on_delete=models.CASCADE, default=None)


class Position(models.Model):
    positionid = models.AutoField(db_column='PositionId', primary_key=True)
    position = models.IntegerField(db_column='Position')
    mappositionsid = models.ForeignKey(MapPositions, on_delete=models.CASCADE, default=None)


class MedievalBattle(models.Model):
    gameid = models.AutoField(db_column='MedievalBattleId', primary_key=True)
    sessionid = models.ForeignKey(SessionMedievalBattle, on_delete=models.CASCADE, default=None)