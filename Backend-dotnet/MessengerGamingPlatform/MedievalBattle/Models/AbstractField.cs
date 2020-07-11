using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedievalBattle.Models
{
    public class AbstractField
    {
        [Key]
        public int abstractFieldId { get; set; }

        // Field characteristics
        public int teamId { get; set; }
        public int positionId { get; set; } // Будет в отдельной таблице enum
        public int fieldSize { get; set; }

        public int fieldHp { get; set; }
        public int fieldDamage { get; set; }
        public int fieldArmor { get; set; }
        public int fieldUnitCount { get; set; }

        // Unit characteristics
        public int hpPerUnit { get; set; }
        public int damagePerUnit { get; set; }
        public int unitCost { get; set; }


        public LocalStatistic LocalStatistic { get; set; }
        public GameController gameController { get; set; }
        public List<Unit> Units { get; set; }
        public List<AbstractField> Enemies { get; set; }

    }
}
