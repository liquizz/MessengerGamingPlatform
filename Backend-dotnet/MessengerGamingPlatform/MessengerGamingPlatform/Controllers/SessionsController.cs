using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Component.Database.Models;
using Component.Database.DTO;
using Component.Database.ReadServices.Sessions;
using Component.Database.ReadServices.Sessions.Interfaces;

namespace Component.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        readonly ISessionReadService _service;

        public SessionsController(SessionReadService service)
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