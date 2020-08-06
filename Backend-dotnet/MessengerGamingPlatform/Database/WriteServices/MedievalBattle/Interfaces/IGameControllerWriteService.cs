using System.Collections.Generic;
using Database.Models.MedievalBattleModels;

namespace Database.WriteServices.MedievalBattle.Interfaces
{
    public interface IGameControllerWriteService
    {
        public bool FillArea(int userId, int unitsCount, int classId, int areaId, int unitCost); // SetField in original logic -> Fills user's area with unitsCount amount of units
        public bool CreateArcherUnit(int count, int teamId, int position, List<AbstractField> enemy, GameController mapController);
    }
}