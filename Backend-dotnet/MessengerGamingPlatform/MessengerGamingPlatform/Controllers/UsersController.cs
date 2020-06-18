using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database.Models;
using Database.DTO;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public UsersController(DatabaseContext context)
        {
            context = _context;
        }

        [HttpGet]
        public ActionResult<User> GetUsers(int id)
        {
            
            return null;
        }

        [HttpPost]
        public ActionResult<StatusResponse> CreateUserTelegram(string Username, string TelegramId)
        {
            
            return null;
        }
        
        [HttpDelete]
        public ActionResult<StatusResponse> DeleteUser()
        {
            return null;
        }
    }
}