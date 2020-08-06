﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models.MedievalBattleModels
{
    public class AbstractField
    {
        [Key]
        public int AbstractFieldId { get; set; }

        // Field characteristics
        public int TeamId { get; set; }
        public int PositionId { get; set; } // Будет в отдельной таблице enum
        public int FieldSize { get; set; }

        public int FieldHp { get; set; }
        public int FieldDamage { get; set; }
        public int FieldArmor { get; set; }
        public int FieldUnitCount { get; set; }
        public int AliveUnitCount { get; set; }
        public int DeadUnitCount { get; set; }

        public string? TypeName { get; set; }

        // Unit characteristics
        public int HpPerUnit { get; set; }
        public int DamagePerUnit { get; set; }
        public int UnitCost { get; set; }
        public int UnitSize { get; set; }


        public LocalStatistic LocalStatistic { get; set; }
        public GameController GameController { get; set; }
        public List<Unit> Units { get; set; }
        public List<AbstractField> Enemies { get; set; }

    }
}
