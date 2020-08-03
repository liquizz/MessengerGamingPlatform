using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models.MedievalBattleModels
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public int Hp { get; set; }
        public int Damage { get;set; }
        public int Armor { get; set; }
        public int ArmorDurability { get; set; }
        public AbstractField ParentObject { get; set; }
    }
}
