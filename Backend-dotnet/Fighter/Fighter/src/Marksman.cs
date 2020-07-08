using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.src
{
    class Marksman : AbstractField //Класс дальников
    {
        override protected List<int> SelectedAlgorithm() //Метод возвращающий доступные для атаки вражеские ячейки (точнее их id), нужен для того что бы бот создавал клавиатуру из этих значений
        {
            List<int> var = null;
            for (int id = 0; id < 8; id++) 
            {
                if (enemy[id] != null)
                {
                    var.Add(id);
                }
            }
            return var;
        }
    }

    class Archer : Marksman //Тип (под класс) лучников
    {
        public Archer(int count, List<AbstractField> enemy)
        {
            typeName = "Archer";

            this.enemy = enemy;
            this.count = count;
            hpPerUnit = 100;
            damagePerUnit = 10;
            armor = 0;
            dimensions = 1;
            units = new Unit[count];
            FillField(count);
        }

    }
}
