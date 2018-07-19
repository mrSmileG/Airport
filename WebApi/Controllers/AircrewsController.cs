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
    [Route("api/aircrews")]
    public class AircrewsController : BaseController<AircrewDto>
    {
        public AircrewsController(IService<AircrewDto> service) : base(service)
        {
        }

        [HttpGet("synch/{count}")]
        public async Task PostRemoteCrewsToDbAsync(int count)
        {
            await (_service as IServiceRemote).SynchronizeRemoteData(count);
        }
    }
}
