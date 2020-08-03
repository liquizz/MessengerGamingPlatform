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
    abstract class AbstractArea
    {
        protected GameController mapController;

        // Характеристики Поля:
        protected int teamId;
        protected int position; // 0 - 7
        protected int size = 100; //Размер поля

        // Характеристики Юнитов:
        protected int hpPerUnit,
                      damagePerUnit,
                      unitCost,
                      hp,               //Зависим от количества
                      damage,           //Зависим от количества
                      armor,            //Не зависим от количества
                      count,            //Кол-во юнитов
                      aliveCount,
                      deadCount;
        protected string TypeName;
        protected int Dimensions;       //Занимаемый юнитом размер поля. (Должно быть кратно полю size)
        protected Unit[] Units;
        protected List<AbstractArea> Enemy;

        public abstract List<int> SelectedAlgorithm(); //Метод возвращающий доступные для атаки вражеские ячейки (точнее их id), нужен для того что бы бот создавал клавиатуру из этих значений
        public abstract void Attack(int attackedFieldId);

        public void FillField(int count)
        { //Заполняет поле юнитами в зависимости от Размера поля (size), Габоритов юнитов (Dimensions), и их количества (count)
            this.aliveCount = count;
            this.deadCount = 0;
            for (int i = 0; i < count; i++)
            {
                Units[i] = new Unit(hpPerUnit, damagePerUnit, armor, i, this);
            }
            //Делит поле на N ячеек, так что бы в одну влезал один юнит данного типа.
            //Юниты заполняют рандомные клетки, если их не максимально количество
            //Должно возвращать масив с растановкой войск.
        }

        public string GetFieldState()
        {
            string state = ( "Живые: " + aliveCount + " Мертвые:" + deadCount );
            return state;
        }

        public string GetUnitsState() //Возвращает состояние всех юнитов на клетке.
        {
            string state = "";
            for (int i = 0; i < count; i++) {
                if (Units[i] != null)
                {
                    state +=  Units[i].hp + " ";
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
                int unitPos = rnd.Next(1, size / Dimensions); //Рандомиться ячейка в которую попадет стрела (если 0, то стрела не попала не куда)
                if (unitPos < count)
                {
                    if (Units[unitPos] != null)
                    {
                        Units[unitPos].DealingDamage(shellDamage);
                    }
                }
            }
        }

        public void DirectExposure(AbstractArea attackDealers) {
            Random rnd = new Random();
            for (int i = 0; i < (((size / 5) > aliveCount) ? aliveCount : (size / 5)) /*береться 20% юнитов от макс кол-ва, если юнитов меньеше беруться все*/; i++)
            {
                int a = rnd.Next(1, 4);
                if (a == 1)
                {
                    attackDealers.Units[i].DealingDamage(this.damagePerUnit);
                }
                else if (a == 2)
                {
                    this.Units[i].DealingDamage(attackDealers.damagePerUnit);
                }
            }
            //20% от Макс защищающихся сталкиваться 20% от макс защищающихся
            //каждый нападающий наносит урон с определенным шансом одному из тех 20% и атака тоже имеет шанс покоцаться
        }

        public void UnitDeath (int id)
        {
            Units[id] = null;
            deadCount++;
            if(--aliveCount == 0)
            {
                mapController.RemoveField(teamId, position);
            }
        }

        public int GetCost ()
        {
            return (unitCost * count);
        }

        public string GetType()
        {
            return TypeName;
        }
    }

    class Hybrid : AbstractArea {
        public override List<int> SelectedAlgorithm() {
            List<int> var = null;
            return var;
        }

        public override void Attack(int attackedFieldId)
        {
            throw new NotImplementedException();
        }
    }
}