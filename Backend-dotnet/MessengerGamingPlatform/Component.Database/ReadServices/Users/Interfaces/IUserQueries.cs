using Component.Database.DTO;
using Component.Database.Models;

namespace Component.Database.ReadServices.Users.Interfaces
{
    public interface IUserQueries
    {
        public CreateUser GetUserIdByTelegram(string telegramid);
        public CreateUser GetUserIdByDiscord(string discordid);
        public User GetUserByUserId(int UserId);

    }
}