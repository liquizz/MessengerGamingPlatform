using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class UnitClasses
    {
        [Key]
        public int UnitClassesId { get; set; }
        public string ClassName { get; set; }
        public int HealPoints { get; set; }
        public int DefencePoints { get; set; }
        public float AttackRange { get; set; }
        public float AttackCooldown { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
