using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.src
{
    class Unit {
        public int hp, 
                   damage,
                   armor,
                   armorDurability,
                    id;
        AbstractArea father;

        public Unit(int hp, int damage, int armor, int id, AbstractArea field)
        {
            this.hp = hp;
            this.damage = damage;
            this.armor = armor;
            this.father = field;
            this.id = id;
        }

        public void DoDamage(int damag)
        {

            if (armorDurability != 0)
            {
                hp -= (damage - armor);
                armorDurability--;
            }
            else
            {
                hp -= damag;
            }

            if (hp <= 0)
            {
                Delete();
            }
        }
        
        void Delete()
        {
            father.UnitDeath(id);
        }
    }
}
