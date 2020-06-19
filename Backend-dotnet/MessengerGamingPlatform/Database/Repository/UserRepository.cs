﻿using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Repository
{
    public class UserRepository
    {
        DatabaseContext _context;
        public UserRepository()
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
    }
}