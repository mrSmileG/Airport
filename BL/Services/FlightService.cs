using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public sealed class FlightService : BaseService<FlightDto, Flight>
    {
        public FlightService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.FlightRepository;
        }
    }
}
