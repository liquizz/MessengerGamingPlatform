using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.src
{
    class Marksman : AbstractArea //Класс дальников
    {
        override public List<int> SelectedAlgorithm() //Метод возвращающий доступные для атаки вражеские ячейки (точнее их id), нужен для того что бы бот создавал клавиатуру из этих значений
        {
            List<int> var = new List<int>();
            for (int id = 0; id < 8; id++) 
            {
                if (Enemy[id] != null)
                {
                    var.Add(id);
                }
            }
            return var;
        }

        public override void Attack(int attackedFieldId)
        {
            Enemy[attackedFieldId].LongRangeExposure(this.count, this.damagePerUnit);
        }
    }

    class Archer : Marksman //Тип (под класс) лучников
    {
        public Archer(int count, int teamId, int position, List<AbstractArea> enemy, GameController mapController)
        {
            this.mapController = mapController;

            TypeName = "Archer";
            this.teamId = teamId;
            this.position = position;

            this.Enemy = enemy;
            this.count = count;
            hpPerUnit = 100;
            damagePerUnit = 10;
            armor = 0;
            Dimensions = 1;
            Units = new Unit[count];
            FillField(count);
        }

    }
}
