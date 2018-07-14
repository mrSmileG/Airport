using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    public interface IRepositoryUnit
    {
        IRepository<Departure> DepartureRepository { get; }

        IRepository<Flight> FlightRepository { get; }

        IRepository<Aircrew> AircrewRepository { get; }

        IRepository<Pilot> PilotRepository { get; }

        IRepository<Plane> PlaneRepository { get; }

        IRepository<PlaneType> PlaneTypeRepository { get; }

        IRepository<Steward> StewardRepository { get; }

        IRepository<Ticket> TicketRepository { get; }
    }
}
