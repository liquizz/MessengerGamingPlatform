﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Component.Database.Models
{
    public class UsersSessionsMedievalBattle
    {

        //Почитать про VirtualTable

        [Key]
        public int UsersSessionsMedievalBattleId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int SessionMedievalBattleId { get; set; }
        public SessionMedievalBattle SessionMedievalBattle { get; set; }
    }
}
