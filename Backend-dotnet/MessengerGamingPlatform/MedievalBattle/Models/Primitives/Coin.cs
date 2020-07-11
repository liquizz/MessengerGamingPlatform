using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedievalBattle.Models.Primitives
{
    public class Coin
    {
        [Key]
        public int coinId { get; set; }
        public int value { get; set; }
    }
}
