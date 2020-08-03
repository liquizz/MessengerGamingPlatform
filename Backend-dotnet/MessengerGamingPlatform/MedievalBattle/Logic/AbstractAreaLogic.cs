using System;
using System.Collections.Generic;
using Database.DTO.MedievalBattleDTO;
using Database.Models.MedievalBattleModels;


namespace MedievalBattle.Logic
{
    public class AbstractAreaLogic
    {
        //public void FillField(int count)
        //{ //Заполняет поле юнитами в зависимости от Размера поля (size), Габоритов юнитов (Dimensions), и их количества (count)
        //    this.aliveCount = count;
        //    this.deadCount = 0;
        //    for (int i = 0; i < count; i++)
        //    {
        //        Units[i] = new Unit(hpPerUnit, damagePerUnit, armor, i, this);
        //    }
        //    //Делит поле на N ячеек, так что бы в одну влезал один юнит данного типа.
        //    //Юниты заполняют рандомные клетки, если их не максимально количество
        //    //Должно возвращать масив с растановкой войск.
        //}

        public GetAreaStateDTO GetAreaState(GetUnitsAliveCountDTO aliveCount, GetUnitsDeadCountDTO deadCount)
        {
            GetAreaStateDTO areaState = new GetAreaStateDTO()
            {
                Alive = aliveCount.AliveUnitCount,
                Dead = deadCount.DeadUnitCount
            };

            return areaState;
        }

        public void LongRangeExposure(int shellCount, int shellDamage, AbstractField area)
        { // Amount of archers and damage per 1 archer
            Random rnd = new Random();
            for (int i = 0; i < shellCount; i++)
            {
                int unitPos = rnd.Next(1, area.FieldSize / area.UnitSize); //Рандомиться ячейка в которую попадет стрела (если 0, то стрела не попала не куда)
                if (unitPos < area.FieldUnitCount)
                {
                    if (area.Units[unitPos] != null)
                    {
                        area.Units[unitPos].DealingDamage(shellDamage);
                    }
                }
            }
        }
    }
}