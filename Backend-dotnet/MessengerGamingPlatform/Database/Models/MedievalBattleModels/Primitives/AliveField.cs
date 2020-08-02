using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models.MedievalBattleModels
{
    public class AliveField
    {
        [Key]
        public int aliveFieldId { get; set; }
        public int fieldIndex { get; set; }
    }
}
