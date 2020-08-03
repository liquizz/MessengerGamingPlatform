using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;

namespace Database.Models.MedievalBattleModels
{
    public class GameController
    {
        [Key]
        public int GameControllerId { get; set; }

        public int SessionMedievalBattleId { get; set; }
        public SessionMedievalBattle SessionMedievalBattle { get; set; }
        public List<Coin> Coins { get; set; }
        public List<AliveField> AliveFieldsCount { get; set; }
        public bool GameAvaliable { get; set; }
        public int? DefeatTeam { get; set; }
        public int CurrentTurn { get; set; }
    }
}
