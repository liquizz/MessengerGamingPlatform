using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Component.Database.Models;
using Component.Database.DTO;
using Component.Database.ReadServices.Users;
using Component.Database.ReadServices.Users.Interfaces;

namespace Component.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly DatabaseContext _context;
        private readonly IUserReadService _service;

        public UsersController(UserReadService service)
        {
            //context = _context;
            _service = service;
        }

        [HttpGet]
        public Object GetUserByTelegram(string telegramid)
        {
            var result = _service.GetUserByTelegramId(telegramid);
            return result;
        }

        [HttpGet]
        public Object GetUserByDiscord(string discordid)
        {
            var result = _service.GetUserByDiscordId(discordid);
            return result;
        }

        [HttpGet]
        public ActionResult<Object> CreateTelegramUser(string Username, string TelegramId)
        {
            var response = _service.CreateUserByTelegramId(Username, TelegramId);

            return response;
        }

        [HttpGet]
        public ActionResult<CreateUser> CreateDiscordUser(string Username, string DiscordId)
        {
            var response = _service.CreateUserByDiscordId(Username, DiscordId);
            return response;
        }

        //Добавить метод объединения двух пользователей.
        [HttpGet]
        public ActionResult<User> GetUserByUserId(int userid)
        {
            var response = _service.GetUserByUserId(userid);
            return response;
        }

        [HttpDelete]
        public ActionResult<StatusResponse> DeleteUser()
        {

            return null;
        }
    }
}