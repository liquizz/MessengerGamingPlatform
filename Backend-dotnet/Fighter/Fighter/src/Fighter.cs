using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.src
{
    class Fighter : AbstractField // Козочки 
    {
        override public List<int> SelectedAlgorithm() //Метод возвращающий доступные для атаки вражеские ячейки (точнее их id), нужен для того что бы бот создавал клавиатуру из этих значений
        {
            List<int> var = new List<int>();

            for (int id = 0; id < 8; id++)
            {
                if (enemy[id] != null)
                {
                    int line = id / 2;
                    if (enemy[line * 2] != null)
                    {
                        var.Add(line * 2);
                    }
                    if (enemy[line * 2 + 1] != null)
                    {
                        var.Add(line * 2 + 1);
                    }
                    return var;
                }
            }
            return var;
        }

        public override void Atack(int atackedFieldId)
        {
            enemy[atackedFieldId].DirectExposure(this);
        }
    }

    class Warrior: Fighter
    {
        public Warrior(int count, int teamId , int position, List<AbstractField> enemy, GameController mapController)
        {
            this.mapController = mapController;

            typeName = "Warrior";
            this.teamId = teamId;
            this.position = position;

            this.enemy = enemy;
            this.count = count;
            hpPerUnit = 100;
            damagePerUnit = 20;
            armor = 10;
            dimensions = 1;
            units = new Unit[count];
            FillField(count);
        }
    }
}
