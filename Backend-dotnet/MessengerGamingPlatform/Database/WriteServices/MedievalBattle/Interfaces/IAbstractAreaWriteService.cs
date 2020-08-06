using Database.Models.MedievalBattleModels;

namespace Database.WriteServices.MedievalBattle.Interfaces
{
    public interface IAbstractAreaWriteService
    {
        public bool FillArea(int unitsAmount); // Fill the Area with unitsAmount
    }
}