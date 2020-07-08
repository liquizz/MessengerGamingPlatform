using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;

namespace Fighter.src
{
    


    abstract class AbstractField
    {
        // Характеристики Поля:
        protected byte position; // 0 - 7
        protected int size = 100; //Размер поля

        // Характеристики Юнитов:
        protected int hpPerUnit,
                      damagePerUnit,
                      unitCost,
                      hp,               //Зависим от количества
                      damage,           //Зависим от количества
                      armor,            //Не зависим от количества
                      count,            //Кол-во юнитов
                      liveCount,
                      deadCount;
        protected string typeName;
        protected int dimensions;       //Занимаемый юнитом размер поля. (Должно быть кратно полю size)
        protected Unit[] units;
        protected List<AbstractField> enemy;

        protected abstract List<int> SelectedAlgorithm(); //Метод возвращающий доступные для атаки вражеские ячейки (точнее их id), нужен для того что бы бот создавал клавиатуру из этих значений
        public void FillField(int count)
        { //Заполняет поле юнитами в зависимости от Размера поля (size), Габоритов юнитов (dimensions), и их количества (count)
            this.liveCount = count;
            this.deadCount = 0;
            for (int i = 0; i < count; i++)
            {
                units[i] = new Unit(hpPerUnit, damagePerUnit, armor, i, this);
            }
            //Делит поле на N ячеек, так что бы в одну влезал один юнит данного типа.
            //Юниты заполняют рандомные клетки, если их не максимально количество
            //Должно возвращать масив с растановкой войск.
        }

        public string GetFieldState()
        {
            string state = ( "Живые: " + liveCount + " Мертвые:" + deadCount );
            return state;
        }

        public string GetUnitsState() //Возвращает состояние всех юнитов на клетке.
        {
            string state = "";
            for (int i = 0; i < count; i++) {
                if (units[i] != null)
                {
                    state += ( units[i].hp + " ");
                }
                else
                {
                    state += "dead ";
                }
            }

            return state;
        }

        public void LongRangeExposure(int shellCount, int shellDamage) {
            Random rnd = new Random();
            for (int i = 0; i < shellCount; i++) {
                int unitPos =rnd.Next(1, size / dimensions); //Рандомиться ячейка в которую попадет стрела (если 0, то стрела не попала не куда)
                if (units[unitPos] != null) {
                    units[unitPos].DealingDamage(shellDamage);
                }
            }
        }

        void DirectExposure(AbstractField atackDilers) {
            Random rnd = new Random();
            for (int i = 0; i < size / 5; i++)
            {
                int a = rnd.Next(1, 4);
                if (a == 1)
                {
                    atackDilers.units[i].DealingDamage(this.damagePerUnit);
                }
                else if (a == 2)
                {
                    this.units[i].DealingDamage(atackDilers.damagePerUnit);
                }
            }
            //20% от Макс защищающихся сталкиваться 20% от макс защищающихся
            //каждый нападающий наносит урон с определенным шансом одному из тех 20% и атака тоже имеет шанс покоцаться
        }

        public void UnitDeath (int id)
        {
            units[id] = null;
            liveCount--;
            deadCount++;
        }

        public int GetCost ()
        {
            return (unitCost * count);
        }

        public string GetType()
        {
            return typeName;
        }
    }

    class Hybrid : AbstractField {
        override protected List<int> SelectedAlgorithm() {
            List<int> var = null;
            return var;
        }
    }
}