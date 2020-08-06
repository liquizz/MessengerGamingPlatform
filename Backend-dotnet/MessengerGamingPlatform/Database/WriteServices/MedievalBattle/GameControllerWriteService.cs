using Database.Models.MedievalBattleModels;
using Database.ReadServices.MedievalBattle;
using Database.WriteServices.MedievalBattle.Interfaces;
using System.Collections.Generic;

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

        public bool CreateArcherUnit(int count, int teamId, int position, List<AbstractField> enemy, GameController mapController)
        {
            throw new System.NotImplementedException();
        }
    }
}