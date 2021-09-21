using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Component.Database.DTO;
using Component.Database.ReadServices.Sessions.Interfaces;
using Component.Database.WriteServices.Sessions;
using Component.Database.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Component.Database.ReadServices.Sessions
{
    public class SessionReadService : ISessionReadService
    {
        readonly ISessionQueries _query;
        SessionWriteService _repository;

        public SessionReadService(ISessionQueries queries)
        {
            SessionWriteService repository = new SessionWriteService();
            _repository = repository;
            _query = queries;
        }

        //Получаем список учасников сессии по SessionId
        public List<SessionParticipants> GetSessionsParticipants(int SessionId)
        {
            var result = _query.GetSessionParticipants(SessionId);
            return result;
        }

        //Создаем сессию для пользователя с UserId
        public Session CreateSessionMedievalBattles(int UserId)
        {
            //throw new Exception("pidoras");
            var response = _repository.CreateSessionMedievalBattles(UserId);
            return GetSession(UserId);
        }

        //Получаем сессию по UserId
        public Session GetSession(int UserId)
        {
            var response = _query.GetSession(UserId);
            return response;
        }

        //Получаем открытую сессию
        public List<Session> GetOpenSessions()
        {
            var response = _query.GetSessionViaStatus();
            return response;
        }

        // Этот метод должен создать запись UsersSessionsMedievalBattle через репо, и проверять
        // заполнена ли сессия. Если да, то поменять статус у сессии, если нет, то оставить как есть.
        // Если в игре будут учавствовать более 2 игроков, нужно немного поменять код.
        public Session JoinSession(int UserId)
        {
            var openSessions = GetOpenSessions();

            if(openSessions == null)
            {
                var newsession = CreateSessionMedievalBattles(UserId);
                return newsession;
            }

            foreach (Session openSession in openSessions)
            {
                var SessionId = openSession.SessionMedievalBattleId;
                var sessionParticipants = _query.GetSessionParticipants(SessionId);

                if (sessionParticipants.Count >= 2)
                {
                    var changedStatus = _repository.ChangeSessionStatus(SessionId);
                    //return false;
                }
                else
                {
                    var lobby = _repository.CreateUsersSessionMedievalBattles(UserId, SessionId);
                    var session = _repository.ChangeSessionStatus(SessionId);
                    var retsession = _query.GetSession(UserId);

                    return retsession;
                }
            }
            return null;
        }

        public bool LeaveSession(int UserId)
        {
            var session = GetSession(UserId);
            var participants = GetSessionsParticipants(session.SessionMedievalBattleId);
            var sessionid = session.SessionMedievalBattleId;
            var usessionid = _query.GetUsession(UserId).UsersSessionsMedievalBattleId;

            if (participants.Count == 1)
            {
                // remove entire session
                _repository.DeleteSessionMedievalBattles(sessionid, usessionid);
                return true;
            }
            else
            {
                // remove lobby
                _repository.DeleteUsersSessionMedievalBattles(UserId);
                return true;
            }
        }
    }
}
