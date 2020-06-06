from django.db import models
import MainPlatformApp.models as models_mp

# Create your models here.


class UnitClasses(models.Model):
    unitclassid = models.AutoField(db_column='UnitClassId', primary_key=True)
    unitclassname = models.CharField(db_column='UnitClassName', max_length=30)
    unitclassdescription = models.TextField(db_column='UnitClassDescription')
    unitstarthealpoints = models.IntegerField(db_column='UnitStartHealPoints')
    unitstartdefencepoints = models.IntegerField(db_column='UnitStartDefencePoints')
    unitattackrange = models.IntegerField(db_column='UnitAttackRange')
    unitattackcooldown = models.FloatField(db_column='UnitAttackCooldown')  # Здесь выбрал флоат, так как это секунды.


class Unit(models.Model):
    unitid = models.AutoField(primary_key=True, db_column='UnitId')
    unitcustomname = models.CharField(db_column='UnitCustomName', max_length=30)
    unitclassid = models.ForeignKey(UnitClasses)
    unitcurrhp = models.IntegerField(db_column='UnitCurrentHealPoints')
    unitcurrdp = models.IntegerField(db_column='UnitCurrentDefencePoints')


class Position(models.Model):
    positionid = models.AutoField(db_column='PositionId', primary_key=True)
    position = models.IntegerField(db_column='Position')


class SessionMedievalBattle(models.Model):
    sessionid = models.AutoField(db_column='SessionId')
    userid = models.ForeignKey(models_mp.User)


class Player(models.Model):
    userid = models.ForeignKey(SessionMedievalBattle)


class MapPositions(models.Model):
    mappositionsid = models.AutoField(db_column='MapPositionsId', primary_key=True)
    unitid = models.ForeignKey(Unit)
    positionid = models.ForeignKey(Position)


class MedievalBattle(models.Model):
    gameid = models.AutoField(db_column='MedievalBattleId')
    sessionid = models.ForeignKey(SessionMedievalBattle)
