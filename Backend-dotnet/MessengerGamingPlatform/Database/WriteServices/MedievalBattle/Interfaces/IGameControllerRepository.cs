using System.Collections.Generic;
using Database.DTO.MedievalBattleDTO;
using Database.Models.MedievalBattleModels;

namespace Database.WriteServices.MedievalBattle.Interfaces
{
    public interface IGameControllerRepository
    {
        public bool CreateCoin(int teamId, int value);
        public bool UpdateCoin(int teamId, int value);
        public bool DeleteCoin(int teamId);
        public bool CreateGameController(); // Initializes game (creates required fields in DB)
        public bool AreaUpdate(int areaId, SetAreaDTO unitField);
        public bool CreateUnit(int areaId, string unitType, int unitCount, int teamId, int positionId, GameController controller, List<AbstractField> enemiesFields);
    }
}