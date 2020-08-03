using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Database.DTO;
using Database.Helpers.Sql;
using Database.Models;
using Database.ReadServices.Users.Interfaces;
using Microsoft.Data.SqlClient;

namespace Database.ReadServices.Users
{
    public class UserQueries : IUserQueries
    {
        private string _connectionString;
        public UserQueries(IConnectionStringHelper helper)
        {
            _connectionString = helper.ConnectionString;
        }

        public CreateUser GetUserIdByTelegram(string telegramid)
        {
            string sqlquery = $@"select * from Users where Telegram = '{telegramid}'";

            var user = new CreateUser();

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                user = db.Query<CreateUser>(sqlquery).FirstOrDefault();
            }

            return user;
        }

        public CreateUser GetUserIdByDiscord(string discordid)
        {
            string sqlquery = $@"select * from Users where Discord = {discordid}";

            var user = new CreateUser();

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                user = db.Query<CreateUser>(sqlquery).FirstOrDefault();
            }

            return user;
        }
        public User GetUserByUserId(int UserId)
        {
            string sqlquery = $@"select * from Users where UserId = {UserId}";

            var user = new User();

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                user = db.Query<User>(sqlquery).FirstOrDefault();
            }

            return user;
        }
    }
}
