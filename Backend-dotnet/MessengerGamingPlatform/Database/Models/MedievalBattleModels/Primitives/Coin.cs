﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models.MedievalBattleModels
{
    public class Coin
    {
        [Key]
        public int CoinId { get; set; }
        public int Value { get; set; }
        public int TeamId { get; set; } 
    }
}
