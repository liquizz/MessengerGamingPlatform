using Database.Models.MedievalBattleModels;

namespace Database.WriteServices.MedievalBattle.Interfaces
{
    public interface IAbstractAreaRepository
    {
        public bool CreateAbstractArea();
        public bool UpdateAbstractAreaCounters(int abstractAreaId, int aliveCount, int deadCount);
        public bool DeleteAbstractArea();
        public bool CreateUnit();
        public bool UpdateUnit(int unitId, int hpPerUnit, int damagePerUnit, int armor, AbstractField abstractAreaId);
        public bool DeleteUnit();
    }
}