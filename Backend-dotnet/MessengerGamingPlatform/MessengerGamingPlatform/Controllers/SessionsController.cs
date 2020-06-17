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
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public SessionsController(DatabaseContext context)
        {
            context = _context;
        }

        public ActionResult<SessionStatus> CreateSession()
        {
            
            return null;
        }

        public ActionResult<SessionStatus> DeleteSession()
        {
            return null; 
        }
    }
}