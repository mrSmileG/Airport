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
    [Route("api/stewards")]
    public class StewardsController : BaseController<StewardDto>
    {

        public StewardsController(IService<StewardDto> service) : base(service)
        {
        }
    }
}
