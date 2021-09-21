using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Component.Database.DTO;
using Component.Database.Models;
using Component.Database.ReadServices.Users.Interfaces;
using Component.Database.WriteServices.Users;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace Component.Database.ReadServices.Users
{
    public class UserReadService : IUserReadService
    {
        UsersWriteService _repository;
        IUserQueries _query;

        public UserReadService(IUserQueries queries)
        {
            _repository = new UsersWriteService();
            _query = queries;
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
            if (_query.GetUserIdByTelegram(telegamid) == null)
            {
                return null;
            }
            else
            {
                var result = _query.GetUserIdByTelegram(telegamid);
                return result;
            }          
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
            if(_query.GetUserIdByDiscord(discordid) == null)
            {
                return null;
            }
            else
            {
                var result = _query.GetUserIdByDiscord(discordid);
                return result;
            }
        }

        //Получаем информацию о пользователе с UserId (не безопасно...)
        public User GetUserByUserId(int UserId)
        {
            if(_query.GetUserByUserId(UserId) == null)
            {
                return null;
            }
            else
            {
                var result = _query.GetUserByUserId(UserId);
                return result;
            }
        }

        public Object DeleteUser(int UserId)
        {
            return null;
        }
    }
}
