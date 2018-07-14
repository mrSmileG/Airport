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
    [Route("api/planes")]
    public class PlanesController : BaseController<PlaneDto>
    {
        public PlanesController(IService<PlaneDto> service) : base(service)
        {
            
        }
    }
}