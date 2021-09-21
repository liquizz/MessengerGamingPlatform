using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Component.Database.Models;
using Component.Database.WriteServices.Users.Interfaces;

namespace Component.Database.WriteServices.Users
{
    public class UsersWriteService : IUsersWriteService
    {
        readonly DatabaseContext _context;
        public UsersWriteService()
        {
            _context = new DatabaseContext();
        }
        public bool CreateUserByTelegramId(string username, string telegramid)
        {
            var user = new User
            {
                Username = username,
                Telegram = telegramid
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return true;
        }

        public bool CreateUserByDiscordId(string username, string discordid)
        {
            var user = new User
            {
                Username = username,
                Discord = discordid
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return true;
        }

        public bool DeleteUser(int UserId)
        {
            try
            {
                var user = _context.Users.Find(UserId);

                _context.Remove(user);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
