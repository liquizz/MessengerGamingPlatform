using System.Collections.Generic;
using Database.Models.MedievalBattleModels;

namespace Database.DTO.MedievalBattleDTO
{
    public class FillAreaDTO
    {
        public int AliveUnitCount { get; set; }
        public int DeadUnitCount { get; set; }
        public List<Unit> Units { get; set; }
    }
}