using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.DTO
{
    public class SessionParticipants
    {
        public string Username { get; set; }
        public int SessionMedievalBattleId { get; set; }
        public int UsersSessionsMedievalBattleId { get; set; }
    }
}
