using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Repository
{
    public class SessionRepository
    {
        private readonly DatabaseContext _context;
        public SessionRepository()
        {
            _context = new DatabaseContext();
        }
        public bool CreateSessionMedievalBattles(int UserId)
        {
            SessionMedievalBattle session = new SessionMedievalBattle { Status = 1 };

            var Usessions = new UsersSessionsMedievalBattle
            {
                UserId = UserId,
                SessionMedievalBattle = session
            };

            _context.SessionMedievalBattles.Add(session);
            _context.SaveChanges();

            _context.UsersSessionsMedievalBattle.Add(Usessions);
            _context.SaveChanges();

            return true;
        }
    }
}
