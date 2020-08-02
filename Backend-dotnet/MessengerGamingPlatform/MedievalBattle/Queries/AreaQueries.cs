using MedievalBattle.Helpers.Sql;
using MedievalBattle.Queries.Interfaces;

namespace MedievalBattle.Queries
{
    public class AreaQueries : IAreaQueries
    {
        public string _connectionString;
        public AreaQueries(IConnectionStringHelper helper)
        {
            _connectionString = helper.ConnectionString;
        }

        public object GetAreaByAreaId(int areaId)
        {
            throw new System.NotImplementedException();
        }

        public object GetAreaByUserId(int userId)
        {
            throw new System.NotImplementedException();
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

        public object GetUnitsAliveCount(int areaId)
        {
            throw new System.NotImplementedException();
        }

        public object GetUnitsDeadCount(int areaId)
        {
            throw new System.NotImplementedException();
        }
    }
}