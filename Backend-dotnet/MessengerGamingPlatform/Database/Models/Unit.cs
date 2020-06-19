using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitCustomName { get; set; }
        public int UnitCurrentHP { get; set; }
        public int UnitCurrentDP { get; set; }
        public int MapPositioningId { get; set; }
        public MapPositioning MapPositioning { get; set; }
        public UnitClasses UnitClasses { get; set; }
    }
}
