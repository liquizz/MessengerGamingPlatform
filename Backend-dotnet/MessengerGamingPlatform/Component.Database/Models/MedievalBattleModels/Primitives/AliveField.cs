using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Component.Database.Models.MedievalBattleModels
{
    public class AliveField
    {
        [Key]
        public int AliveFieldId { get; set; }
        public int FieldIndex { get; set; }
    }
}
