using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database.Models;
using Database.DTO;
using Api.Sessions;
using Api.Sessions.Interfaces;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        readonly ISessionService _service;

        public SessionsController(SessionService service)
        {
            _service = service;
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
            var response = _service.JoinSession(UserId);

            return response;
        }

        // Дописать
        [HttpGet]
        public Object LeaveSession(int UserId)
        {
            var response = _service.LeaveSession(UserId);
            return response;
        }
    }
}