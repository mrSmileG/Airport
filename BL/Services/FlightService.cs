using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTOs;
using Models;
using BL.Helpers;

namespace BL.Services
{
    public sealed class FlightService : BaseService<FlightDto, Flight>
    {
        public FlightService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.FlightRepository;
        }

        public override async Task<FlightDto> GetAsync(int id)
        {
            return await await FakeDelayHelper.GetWithDelayAsync(base.GetAsync, id);
        }
    }
}
