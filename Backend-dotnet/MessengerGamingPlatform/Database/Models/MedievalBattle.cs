using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class MedievalBattle
    {
        [Key]
        public int MedievalBatlleId { get; set; }
        public int SessionMedievalBattleId { get; set; }
        public SessionMedievalBattle SessionMedievalBattle { get; set; }
        public List<Player> Players { get; set; }
    }
}
