using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Database.DTO;
using Database.Models;
using Microsoft.Data.SqlClient;

namespace Api.Users
{
    public class UserQueries
    {
        private string connectionString = "Server=25.98.56.253;Database=MGP;MultipleActiveResultSets=true;User ID=sa;Password=OKTyaBRSkOE123;";
        public UserQueries()
        {

        }

        public CreateUser GetUserIdByTelegram(string telegramid)
        {
            string sqlquery = $@"select * from Users where Telegram = '{telegramid}'";

            var user = new CreateUser();

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                user = db.Query<CreateUser>(sqlquery).FirstOrDefault();
            }

            return user;
        }

        public CreateUser GetUserIdByDiscord(string discordid)
        {
            string sqlquery = $@"select * from Users where Discord = {discordid}";

            var user = new CreateUser();

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                user = db.Query<CreateUser>(sqlquery).FirstOrDefault();
            }

            return user;
        }
        public User GetUserByUserId(int UserId)
        {
            string sqlquery = $@"select * from Users where UserId = {UserId}";

            var user = new User();

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                user = db.Query<User>(sqlquery).FirstOrDefault();
            }

            return user;
        }
    }
}
