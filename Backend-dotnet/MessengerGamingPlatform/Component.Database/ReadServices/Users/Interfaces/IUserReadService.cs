using System;
using Component.Database.DTO;
using Component.Database.Models;

namespace Component.Database.ReadServices.Users.Interfaces
{
    public interface IUserReadService
    {
        public CreateUser CreateUserByTelegramId(string Username, string telegramid);
        public CreateUser GetUserByTelegramId(string telegamid);
        public CreateUser CreateUserByDiscordId(string Username, string discordid);
        public CreateUser GetUserByDiscordId(string discordid);
        public User GetUserByUserId(int UserId);
        public Object DeleteUser(int UserId);
    }
}