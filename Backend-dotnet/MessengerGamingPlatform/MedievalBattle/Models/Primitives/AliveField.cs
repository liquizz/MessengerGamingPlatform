using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedievalBattle.Models.Primitives
{
    public class AliveField
    {
        [Key]
        public int aliveFieldId { get; set; }
        public int fieldIndex { get; set; }
    }
}
