using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public sealed class PlaneService : BaseService<PlaneDto, Plane>
    {
        public PlaneService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.PlaneRepository;
        }
    }
}
