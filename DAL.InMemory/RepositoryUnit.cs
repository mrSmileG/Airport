using System;
using System.Collections.Generic;
using System.Text;
using DAL.InMemory.Repositories;
using Models;

namespace DAL.InMemory
{
    public class RepositoryUnit : IRepositoryUnit
    {
        private readonly AppContext _appContext;

        private AircrewRepository _aircrewRepository;
        private DepartureRepository _departureRepository;
        private FlightRepository _flightRepository;
        private PilotRepository _pilotRepository;
        private PlaneRepository _planeRepository;
        private PlaneTypeRepository _planeTypeRepository;
        private StewardRepository _stewardRepository;
        private TicketRepository _ticketRepository;

        public RepositoryUnit()
        {
            _appContext = new AppContext();
        }

        public IRepository<Departure> DepartureRepository => _departureRepository ??
                                                             (_departureRepository = new DepartureRepository(_appContext));

        public IRepository<Flight> FlightRepository => _flightRepository ??
                                                       (_flightRepository = new FlightRepository(_appContext));

        public IRepository<Aircrew> AircrewRepository => _aircrewRepository ?? 
                                                         (_aircrewRepository = new AircrewRepository(_appContext));

        public IRepository<Pilot> PilotRepository => _pilotRepository ??
                                                     (_pilotRepository = new PilotRepository(_appContext));

        public IRepository<Plane> PlaneRepository => _planeRepository ??
                                                     (_planeRepository = new PlaneRepository(_appContext));

        public IRepository<PlaneType> PlaneTypeRepository => _planeTypeRepository ??
                                                             (_planeTypeRepository = new PlaneTypeRepository(_appContext));

        public IRepository<Steward> StewardRepository => _stewardRepository ??
                                                         (_stewardRepository = new StewardRepository(_appContext));

        public IRepository<Ticket> TicketRepository => _ticketRepository ??
                                                       (_ticketRepository = new TicketRepository(_appContext));

        public void Save()
        {
            throw new NotImplementedException();
        }

    }
}
