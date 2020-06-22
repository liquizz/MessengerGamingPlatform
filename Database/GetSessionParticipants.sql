use MGP;

select Users.Username, UsersSessionsMedievalBattle.SessionMedievalBattleId
from dbo.SessionMedievalBattles
full join UsersSessionsMedievalBattle on UsersSessionsMedievalBattle.SessionMedievalBattleId = SessionMedievalBattles.SessionMedievalBattleId
full join Users on Users.UserId = UsersSessionsMedievalBattle.UserId
where SessionMedievalBattles.SessionMedievalBattleId = 1;