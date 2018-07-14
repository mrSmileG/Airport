using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public sealed class AircrewService : BaseService<AircrewDto, Aircrew>
    {
        public AircrewService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.AircrewRepository;
        }
    }
}
