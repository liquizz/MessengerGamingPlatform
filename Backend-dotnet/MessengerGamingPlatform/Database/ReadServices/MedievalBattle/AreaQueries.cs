using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Database.DTO;
using Database.DTO.MedievalBattleDTO;
using Database.Helpers.Sql;
using Database.ReadServices.MedievalBattle;
using Microsoft.Data.SqlClient;

namespace Database.ReadServices.MedievalBattle
{
    public class AreaQueries : IAreaQueries
    {
        private string _connectionString;
        public AreaQueries(IConnectionStringHelper helper)
        {
            _connectionString = helper.ConnectionString;
        }

        public object GetAreasByAreaId(int areaId)
        {
            throw new System.NotImplementedException();
        }

        public List<GetAreaByUserIdDTO> GetAreasByUserId(int userId)
        {
            var sqlquery = @$"SELECT TOP (8) [AbstractFieldId]
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
                                      ,[dbo].[AbstractFields].[GameControllerId]
                                      ,[Discriminator]
                                      ,[AbstractFieldId1]
                                      ,[AliveUnitCount]
                                      ,[DeadUnitCount]
                                  FROM [MGP].[dbo].[AbstractFields]
                                  WHERE [dbo].[AbstractFields].[TeamId] = {userId};";
            // TODO: Rename dbo.AbstractFields -> dbo.AbstractAreas, TeamId -> UserId (more relevant)

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<List<GetAreaByUserIdDTO>>(sqlquery).FirstOrDefault();
            }
        }

        public object GetAreaSize(int areaId)
        {
            throw new System.NotImplementedException();
        }

        public object GetAreaState(int userId)
        {
            throw new System.NotImplementedException();
        }

        public object GetDamagePerUnit(int areaId)
        {
            throw new System.NotImplementedException();
        }

        public object GetTypeName(int areaId)
        {
            throw new System.NotImplementedException();
        }

        public object GetUnitList(int areaId)
        {
            throw new System.NotImplementedException();
        }

        public GetUnitsAliveCountDTO GetUnitsAliveCount(int areaId)
        {
            var sqlquery = @$"SELECT [dbo].[AbstractFields].[AliveUnitCount]
                                    FROM [dbo].[AbstractFields]
                                    WHERE [dbo].[AbstractFields].[AbstractFieldId] = {areaId}";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<GetUnitsAliveCountDTO>(sqlquery).FirstOrDefault();
            }
        }

        public GetUnitsDeadCountDTO GetUnitsDeadCount(int areaId)
        {
            var sqlquery = @$"SELECT [dbo].[AbstractFields].[DeadUnitCount]
                                    FROM [dbo].[AbstractFields]
                                    WHERE [dbo].[AbstractFields].[AbstractFieldId] = {areaId}";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<GetUnitsDeadCountDTO>(sqlquery).FirstOrDefault();
            }
        }
    }
}