namespace Database.WriteServices.Sessions.Interfaces
{
    public interface ISessionWriteService
    {
        public bool CreateSessionMedievalBattles(int userId);
        public bool DeleteSessionMedievalBattles(int sessionId, int usessionId);
        public bool CreateUsersSessionMedievalBattles(int userId, int sessionId);
        public bool DeleteUsersSessionMedievalBattles(int userId);
        public bool ChangeSessionStatus(int sessionId);
    }
}