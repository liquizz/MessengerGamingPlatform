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
        public int unitId { get; set; }
        public int hp { get; set; }
        public int damage { get;set; }
        public int armor { get; set; }
        public int armorDurability { get; set; }
        public AbstractField parentObject { get; set; }
    }
}
