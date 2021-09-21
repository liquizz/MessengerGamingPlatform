using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Component.Database.Models.MedievalBattleModels;

namespace Component.Database.Models
{
    public class SessionMedievalBattle
    {
        [Key]
        public int SessionMedievalBattleId { get; set; }
        public int Status { get; set; }
        public List<UsersSessionsMedievalBattle> UsersSessionsMedievalBattles { get; set; }
        public GameController GameController { get; set; }
    }
}
