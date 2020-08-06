using System.Collections.Generic;
using Database.Helpers.Sql;
using Database.ReadServices.MedievalBattle;
using System.Data;
using System.Linq;
using Dapper;
using Database.DTO.MedievalBattleDTO;
using Database.Models.MedievalBattleModels;
using Microsoft.Data.SqlClient;

namespace Database.ReadServices.MedievalBattle
{
    public class GameControllerReadQueries : IGameControllerReadQueries
    {
        private string _connectionString;
        public GameControllerReadQueries(IConnectionStringHelper helper)
        {
            _connectionString = helper.ConnectionString;
        }

        public object GetAvailableAreasCount(int userId)
        {
            throw new System.NotImplementedException();
        }

        // TODO: Fix coins in model
        public GetCoinsDTO GetCoins(int gameControllerId, int teamId)
        {
            var sqlquery = $@"select distinct Coins.Value, Coins.TeamId, Coins.GameControllerId
                                    from Coins
                                    join GameControllers on GameControllers.GameControllerId = Coins.GameControllerId
                                    join AbstractFields on AbstractFields.TeamId = Coins.TeamId
                                    where Coins.GameControllerId = {gameControllerId} and Coins.TeamId = {teamId};";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<GetCoinsDTO>(sqlquery).FirstOrDefault();
            }
        }

        public object GetDefeatTeam(int gameControllerId)
        {
            throw new System.NotImplementedException();
        }

        public object GetGameAvailable(int gameControllerId)
        {
            throw new System.NotImplementedException();
        }

        public object GetTeamsCount(int sessionId)
        {
            throw new System.NotImplementedException();
        }

        public object GetTurn()
        {
            throw new System.NotImplementedException();
        }

        public object GetAreas(int areaId)
        {
            var sqlquery = $@"SELECT TOP (1000) [AbstractFieldId]
                                      ,[TeamId]
                                      ,[PositionId]
                                      ,[FieldSize]
                                      ,[FieldHp]
                                      ,[FieldDamage]
                                      ,[FieldArmor]
                                      ,[FieldUnitCount]
                                      ,[HpPerUnit]
                                      ,[DamagePerUnit]
                                      ,[UnitCost]
                                      ,[LocalStatisticId]
                                      ,[AbstractFields].[GameControllerId]
                                      ,[Discriminator]
                                      ,[AbstractFieldId1]
                                      ,[AliveUnitCount]
                                      ,[DeadUnitCount]
                                      ,[UnitSize]
                                  FROM [MGP].[dbo].[AbstractFields]
                                  JOIN GameControllers on AbstractFields.GameControllerId = GameControllers.GameControllerId
                                  WHERE GameControllers.GameControllerId = {areaId}";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<GetCoinsDTO>(sqlquery).ToList();
            }
        }

        public GetEnemyTeamIdDTO GetEnemyTeamId(int teamId, int gameControllerId)
        {
            var sqlquery = $@"select distinct AbstractFields.TeamId
                                    from AbstractFields
                                    join GameControllers on GameControllers.GameControllerId = AbstractFields.GameControllerId
                                    where GameControllers.GameControllerId = {gameControllerId}
                                    except
                                    select distinct AbstractFields.TeamId
                                    from AbstractFields
                                    join GameControllers on GameControllers.GameControllerId = AbstractFields.GameControllerId
                                    where AbstractFields.TeamId = {teamId} and GameControllers.GameControllerId = {gameControllerId}";
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<GetEnemyTeamIdDTO>(sqlquery).FirstOrDefault();
            }
        }

        public GetGameControllerIdDTO GetGameControllerId(int teamId)
        {
            var sqlquery = $@"select distinct *
                                    from AbstractFields
                                    join GameControllers on GameControllers.GameControllerId = AbstractFields.GameControllerId
                                    where AbstractFields.TeamId = {teamId}";
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<GetGameControllerIdDTO>(sqlquery).FirstOrDefault();
            }
        }

        public GameController GetGameController(int gameControllerId)
        {
            var sqlquery = $@"select *
                                    from GameControllers
                                    where GameControllers.GameControllerId = {gameControllerId};";
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<GameController>(sqlquery).FirstOrDefault();
            }
        }

        public List<AbstractField> GetEnemyAreas(int teamId, int gameControllerId)
        {
            var enemyTeamId = GetEnemyTeamId(teamId, gameControllerId).TeamId;

            var sqlquery = $@"select *
                                    from AbstractFields
                                    where AbstractFields.TeamId = {enemyTeamId};";
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<AbstractField>(sqlquery).ToList();
            }
        }
    }
}