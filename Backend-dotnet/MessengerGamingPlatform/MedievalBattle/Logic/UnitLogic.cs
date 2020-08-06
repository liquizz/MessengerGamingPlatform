using Database.Models.MedievalBattleModels;

namespace MedievalBattle.Logic
{
    public class UnitLogic
    {
        public void DoUnitDamage(int damage, Unit unit)
        {

            if (unit.ArmorDurability != 0)
            {
                unit.Hp -= (damage - unit.Armor);
                unit.ArmorDurability--;
            }
            else
            {
                unit.Hp -= damage;
            }

            if (unit.Hp <= 0)
            {
                RemoveUnit(unit);
            }

            // WriteService.UpdateUnit(unit)
        }

        private static void RemoveUnit(Unit unit) // TODO: We may mark unit as dead, instead of deleting him
        {
            // WriteService.RemoveUnit
        }
    }
}