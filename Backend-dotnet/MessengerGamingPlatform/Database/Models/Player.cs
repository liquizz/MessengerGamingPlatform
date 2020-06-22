using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public int MedievalBattleId { get; set; }
        public MedievalBattle MedievalBattle { get; set; }
        public List<MapPositioning> MapPositionings { get; set; }
    }
}
