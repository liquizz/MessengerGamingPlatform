using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.WriteServices.Users.Interfaces;

namespace Database.WriteServices.Users
{
    public class UsersRepository : IUsersRepository
    {
        readonly DatabaseContext _context;
        public UsersRepository()
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
