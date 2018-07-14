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
    [Route("api/pilots")]
    public class PilotsController : BaseController<PilotDto>
    {
        public PilotsController(IService<PilotDto> service) : base(service)
        {
        }
    }
}
