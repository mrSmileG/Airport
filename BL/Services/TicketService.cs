using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public sealed class TicketService : BaseService<TicketDto, Ticket>
    {
        public TicketService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.TicketRepository;
        }
    }
}
