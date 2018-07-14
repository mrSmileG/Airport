using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public sealed class PilotService : BaseService<PilotDto, Pilot>
    {
        public PilotService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.PilotRepository;
        }
    }
}
