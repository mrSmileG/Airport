using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public sealed class DepartureService : BaseService<DepartureDto, Departure>
    {
        public DepartureService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.DepartureRepository;
        }
    }
}
