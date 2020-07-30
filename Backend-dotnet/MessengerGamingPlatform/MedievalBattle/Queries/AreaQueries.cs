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
    }
}