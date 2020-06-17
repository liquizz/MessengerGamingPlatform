using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        public string Name { get; set; }
        public int PositionNumber { get; set; }
        public int MapPositioningId { get; set; }
        public MapPositioning MapPositioning { get; set; }
    }
}
