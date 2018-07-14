using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public sealed class PlaneTypeService : BaseService<PlaneTypeDto, PlaneType>
    {
        public PlaneTypeService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.PlaneTypeRepository;
        }
    }
}
