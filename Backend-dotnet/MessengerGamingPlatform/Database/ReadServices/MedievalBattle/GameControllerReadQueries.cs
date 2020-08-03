using Database.Helpers.Sql;
using Database.ReadServices.MedievalBattle;

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

        public object GetCoins(int userId)
        {
            throw new System.NotImplementedException();
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
    }
}