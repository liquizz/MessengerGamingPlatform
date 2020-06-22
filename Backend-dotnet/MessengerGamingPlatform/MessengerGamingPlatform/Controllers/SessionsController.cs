using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database.Models;
using Database.DTO;
using Api.Sessions;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private readonly DatabaseContext _context;
        SessionService _service;

        public SessionsController(DatabaseContext context)
        {
            context = _context;
            _service = new SessionService();
        }

        // Сделать метод для получения id сессии
        [HttpGet]
        public Object GetSessionParticipants()
        {
            var result = _service.GetSessionsParticipants(1);
            return result;
        }

        [HttpGet]
        public Object CreateSessionMedievalBattle(int userid)
        {
            var resronse = _service.CreateSessionMedievalBattles(userid);
            return resronse;
        }


        [HttpGet]
        public Object JoinSession(int UserId)
        {


            return null;
        }

        // Дописать
        public ActionResult<StatusResponse> DeleteSession()
        {
            return null;
        }
    }
}