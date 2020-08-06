using System;
using System.Collections.Generic;
using Database.DTO.MedievalBattleDTO;
using Database.Models.MedievalBattleModels;

namespace MedievalBattle.Logic
{
    public class AbstractAreaLogic
    {
        public FillAreaDTO FillArea(AbstractField area, int count) // int areaId, int count
        { //Заполняет поле юнитами в зависимости от Размера поля (size), Габоритов юнитов (Dimensions), и их количества (count)
            var dto = new FillAreaDTO();

            dto.AliveUnitCount = count;
            dto.DeadUnitCount = 0;
            for (int i = 0; i < count; i++) // There will be a huge problem later...
            {
                dto.Units[i] = new Unit()
                {
                    Hp = area.HpPerUnit,
                    Damage = area.DamagePerUnit,
                    Armor = area.FieldArmor,
                    ParentObject = area
                    // unit.Hp, unit.Damage, unit.Armor, unit.UnitId, unit.ParentObject
                };
            }
            //Делит поле на N ячеек, так что бы в одну влезал один юнит данного типа.
            //Юниты заполняют рандомные клетки, если их не максимально количество
            //Должно возвращать масив с растановкой войск.

            return dto;
        }

        public GetAreaStateDTO GetAreaState(GetUnitsAliveCountDTO aliveCount, GetUnitsDeadCountDTO deadCount)
        {
            GetAreaStateDTO areaState = new GetAreaStateDTO()
            {
                Alive = aliveCount.AliveUnitCount,
                Dead = deadCount.DeadUnitCount
            };

            return areaState;
        }

        public void LongRangeExposure(int unitAmount, int unitDamage, AbstractField area, List<Unit> units)
        { // Amount of archers and damage per 1 archer TODO: refactor this later
            var rnd = new Random();
            var unitLogic = new UnitLogic();

            for (int i = 0; i < unitAmount; i++)
            {
                var unitPos = rnd.Next(1, area.FieldSize / area.UnitSize);
                if (unitPos >= area.FieldUnitCount) continue;
                if (area.Units[unitPos] != null)
                {
                    unitLogic.DoUnitDamage(unitDamage, area.Units[unitPos]);
                }
            }
        }

        public void DirectExposure(AbstractField attackDealers, AbstractField attackEncounter)
        {
            var rnd = new Random();
            var unitLogic = new UnitLogic();

            for (int i = 0; i < (((attackEncounter.FieldSize / 5) > attackEncounter.AliveUnitCount) ? attackEncounter.AliveUnitCount : (attackEncounter.FieldSize / 5)) /*береться 20% юнитов от макс кол-ва, если юнитов меньеше беруться все*/; i++)
            {
                int a = rnd.Next(1, 4);
                if (a == 1)
                {
                    unitLogic.DoUnitDamage(attackEncounter.DamagePerUnit, attackDealers.Units[i]);
                    // May not work in current way TODO: think about mapping of that list
                }
                else if (a == 2)
                {
                    unitLogic.DoUnitDamage(attackDealers.DamagePerUnit, attackEncounter.Units[i]);
                    // May not work in current way TODO: think about mapping of that list
                }
            }
            //20% от Макс защищающихся сталкиваться 20% от макс защищающихся
            //каждый нападающий наносит урон с определенным шансом одному из тех 20% и атака тоже имеет шанс покоцаться
        }

        public void UnitDeath(int id, AbstractField area)
        {
            area.Units[id] = null;
            area.DeadUnitCount++;
            // TODO: move this action to WriteService
            if (--area.AliveUnitCount == 0)
            {
                // 
                //mapController.RemoveField(teamId, position);
            }
        }

        public int GetCost()
        {
            // Read actions here
            //return (unitCost * count);
            return 0;
        }

        public string GetType()
        {
            // And here
            //return TypeName;
            return "1";
        }
    }
}