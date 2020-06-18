using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.DTO;
using Database.Models;
using Microsoft.Extensions.DependencyInjection;
using Database.Repository;

namespace Api.Sessions
{
    public class SessionService
    {
        SessionQueries _query;
        SessionRepository _repository;

        public SessionService()
        {
            SessionQueries Query = new SessionQueries();
            SessionRepository repository = new SessionRepository();
            _repository = repository;
            _query = Query;
        }

        public List<SessionParticipants> GetSessionsParticipants()
        {
            var result = _query.GetSessionParticipants();
            return result;
        }

        public Session CreateSessionMedievalBattles(int UserId)
        {
            throw new Exception("pidoras");
            var response = _repository.CreateSessionMedievalBattles(UserId);
            return GetSession(UserId);
        }

        public Session GetSession(int UserId)
        {
            var response = _query.GetSession(UserId);
            return response;
        }
    }
}
