namespace Database.WriteServices.Users.Interfaces
{
    public interface IUsersWriteService
    {
        public bool CreateUserByTelegramId(string username, string telegramid);
        public bool CreateUserByDiscordId(string username, string discordid);
        public bool DeleteUser(int UserId);

    }
}