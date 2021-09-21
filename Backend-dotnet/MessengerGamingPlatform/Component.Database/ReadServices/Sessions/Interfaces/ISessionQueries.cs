﻿using System.Collections.Generic;
using Component.Database.DTO;

namespace Component.Database.ReadServices.Sessions.Interfaces
{
    public interface ISessionQueries
    {
        public List<SessionParticipants> GetSessionParticipants(int SessionId);
        public Session GetSession(int UserId);
        public GetUsersSessionsMedievalBattle GetUsession(int UserId);
        public List<Session> GetSessionViaStatus();

    }
}