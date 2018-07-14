using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Services;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/tickets")]
    public class TicketsController : BaseController<TicketDto>
    {
        public TicketsController(IService<TicketDto> service) : base(service)
        {
            
        }
    }
}