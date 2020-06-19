using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Telegram { get; set; }
        public string Discord { get; set; }
        public List<UsersSessionsMedievalBattle> usersSessionsMedievalBattles { get; set; }
        //public User(string UserId, string Username, string Messanger)
        //{
        //    this.Username = Username;
        //    this.Telegram = ;
        //}
    }
}
