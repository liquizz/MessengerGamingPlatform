using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.src
{
    class Fighter: AbstractField
    {
        override protected List<int> SelectedAlgorithm() //Метод возвращающий доступные для атаки вражеские ячейки (точнее их id), нужен для того что бы бот создавал клавиатуру из этих значений
        {
            List<int> var = null;

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
                }
            }

            return var;
        }
    }

    class Warrior: Fighter
    {
        public Warrior(int count, List<AbstractField> enemy)
        {
            typeName = "Warrior";

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
