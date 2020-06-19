using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class MapPositioning
    {
        [Key]
        public int MapPositioningId { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public Position Position { get; set; }
        public Unit Unit { get; set; }
    }
}
