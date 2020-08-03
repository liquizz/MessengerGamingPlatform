using Database.ReadServices.MedievalBattle;
using Database.WriteServices.MedievalBattle.Interfaces;

namespace Database.WriteServices.MedievalBattle
{
    public class GameControllerWriteService : IGameControllerWriteService
    {
        private readonly IGameControllerReadQueries _queries;
        public GameControllerWriteService(IGameControllerReadQueries queries)
        {
            _queries = queries;
        }

        public bool FillArea(int userId, int unitsCount, int classId, int areaId, int unitCost)
        {
            throw new System.NotImplementedException();
        }

        public bool CreateGameController()
        {
            throw new System.NotImplementedException();
        }
    }
}