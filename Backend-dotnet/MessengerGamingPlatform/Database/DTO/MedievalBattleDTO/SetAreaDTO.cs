using System.Collections.Generic;
using Database.Models.MedievalBattleModels;

namespace Database.DTO.MedievalBattleDTO
{
    public class SetAreaDTO
    {
        public int CoinsUserId { get; set; }
        public int CoinsValue { get; set; }
        public string UnitType { get; set; }
        public List<AbstractField> Units { get; set; }
    }
}