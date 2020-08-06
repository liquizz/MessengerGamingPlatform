using Database.Models;
using Database.Models.MedievalBattleModels;
using Database.WriteServices.MedievalBattle.Interfaces;

namespace Database.WriteServices.MedievalBattle
{
    public class AbstractAreaRepository : IAbstractAreaRepository
    {
        private readonly DatabaseContext _context;

        public AbstractAreaRepository()
        {
            _context = new DatabaseContext();
        }

        public bool CreateAbstractArea()
        {
            throw new System.NotImplementedException();
        }

        public bool CreateUnit()
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteAbstractArea()
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteUnit()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateAbstractAreaCounters(int abstractAreaId, int aliveCount, int deadCount)
        {
            var abstractArea = _context.AbstractFields.Find(abstractAreaId);

            if (abstractArea != null)
            {
                abstractArea.AliveUnitCount = aliveCount;
                abstractArea.DeadUnitCount = deadCount;
                _context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool UpdateUnit(int unitId, int hpPerUnit, int damagePerUnit, int armor, AbstractField abstractAreaId)
        {
            var unit = _context.Units.Find(unitId);

            if (unit != null)
            {
                unit.Hp = hpPerUnit;
                unit.Damage = damagePerUnit;
                unit.Armor = armor;
                unit.ParentObject = abstractAreaId;

                _context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}