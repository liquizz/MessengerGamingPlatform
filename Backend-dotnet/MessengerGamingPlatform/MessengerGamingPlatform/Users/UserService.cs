using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Repository;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using Database.DTO;
using Database.Models;

namespace Api.Users
{
    public class UserService
    {
        UserRepository _repository;
        UserQueries _query;

        public UserService()
        {
            _repository = new UserRepository();
            _query = new UserQueries();
        }
        
        //Логика создания пользователя по TelegramId
        public CreateUser CreateUserByTelegramId(string Username, string telegramid)
        {
            if(GetUserByTelegramId(telegramid) == null)
            {
                var result = _repository.CreateUserByTelegramId(Username, telegramid);
                return GetUserByTelegramId(telegramid);
            }
            else
            {
                return GetUserByTelegramId(telegramid);
            }
            
        }

        public CreateUser GetUserByTelegramId(string telegamid)
        {
            var result = _query.GetUserIdByTelegram(telegamid);
            return result;
        }

        //Логика создания пользователя по DiscordId
        public CreateUser CreateUserByDiscordId(string Username, string discordid)
        {
            if(GetUserByDiscordId(discordid) == null)
            {
                var result = _repository.CreateUserByDiscordId(Username, discordid);
                return GetUserByDiscordId(discordid);
            }
            else
            {
                return GetUserByDiscordId(discordid);
            }
            
        }

        public CreateUser GetUserByDiscordId(string discordid)
        {
            var result = _query.GetUserIdByDiscord(discordid);
            return result;
        }

        //Получаем информацию о пользователе с UserId (не безопасно...)
        public User GetUserByUserId(int UserId)
        {
            var result = _query.GetUserByUserId(UserId);
            return result;
        }
    }
}
