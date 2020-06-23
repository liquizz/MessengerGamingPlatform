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

        public bool DeleteSessionMedievalBattles(int SessionId, int UsessionId)
        {
            var session = _context.SessionMedievalBattles.Find(SessionId);
            var Usession = _context.UsersSessionsMedievalBattle.Find(UsessionId);

            if(session == null || Usession == null)
            {
                return false;
            }

            _context.SessionMedievalBattles.Remove(session);
            _context.UsersSessionsMedievalBattle.Remove(Usession);
            
            return true;  
        }

        // Метод для создания подключения пользователя к сессии (лобби)
        public bool CreateUsersSessionMedievalBattles(int UserId, int SessionId)
        {
            var Usession = new UsersSessionsMedievalBattle
            {
                UserId = UserId,
                SessionMedievalBattleId = SessionId
            };

            _context.UsersSessionsMedievalBattle.Add(Usession);
            _context.SaveChanges();

            return true;
        }

        // Метод для удаления подключения пользователя к сессии (лобби)
        public bool DeleteUsersSessionMedievalBattles(int UserId)
        {
            var Usession = _context.UsersSessionsMedievalBattle.Find(UserId);

            _context.UsersSessionsMedievalBattle.Remove(Usession);
            _context.SaveChanges();

            return true;
        }

        public bool ChangeSessionStatus(int SessionId)
        {
            var session = _context.SessionMedievalBattles.Find(SessionId);

            if(session != null)
            {
                session.Status = 0;
            }

            _context.SaveChanges();

            return true;
        }
    }
}
