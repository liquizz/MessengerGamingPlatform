using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database.Models;
using Database.DTO;
using Api.Users;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly UserService _service;

        public UsersController(DatabaseContext context)
        {
            context = _context;
            _service = new UserService();
        }

        [HttpGet]
        public ActionResult<User> GetUser(int id)
        {
            
            return null;
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