using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public sealed class StewardService : BaseService<StewardDto, Steward>
    {
        public StewardService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.StewardRepository;
        }
    }
}
