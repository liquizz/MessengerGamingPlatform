using System.Collections.Generic;
using Database.DTO;

namespace Api.Sessions.Interfaces
{
    public interface ISessionQueries
    {
        public List<SessionParticipants> GetSessionParticipants(int SessionId);
        public Session GetSession(int UserId);
        public GetUsersSessionsMedievalBattle GetUsession(int UserId);
        public List<Session> GetSessionViaStatus();

    }
}