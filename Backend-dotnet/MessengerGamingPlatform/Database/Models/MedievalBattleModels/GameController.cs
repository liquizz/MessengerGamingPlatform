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
        public int gameControllerId { get; set; }
        public SessionMedievalBattle sessionMedievalBattle { get; set; }
        public List<Coin> coins { get; set; }
        public List<AliveField> aliveFieldsCount { get; set; }
        public bool gameAvaliable { get; set; }
        public int defeatTeam { get; set; }
        public int currentTurn { get; set; }
    }
}
