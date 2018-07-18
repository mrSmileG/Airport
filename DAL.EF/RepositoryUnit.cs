using System;
using System.Collections.Generic;
using System.Text;
using DAL.EF;
using Models;

namespace DAL.EF
{
    public class RepositoryUnit : IRepositoryUnit, IDisposable
    {
        private readonly AppDbContext _appContext;

        private bool _disposed;

        private IRepository<Aircrew> _aircrewRepository;
        private IRepository<Departure> _departureRepository;
        private IRepository<Flight> _flightRepository;
        private IRepository<Pilot> _pilotRepository;
        private IRepository<Plane> _planeRepository;
        private IRepository<PlaneType> _planeTypeRepository;
        private IRepository<Steward> _stewardRepository;
        private IRepository<Ticket> _ticketRepository;

        public RepositoryUnit(AppDbContext appContext)
        {
            _appContext = appContext;
            _disposed = false;
        }

        public IRepository<Departure> DepartureRepository => _departureRepository ??
                                                             (_departureRepository = new Repository<Departure>(_appContext));

        public IRepository<Flight> FlightRepository => _flightRepository ??
                                                       (_flightRepository = new Repository<Flight>(_appContext));

        public IRepository<Aircrew> AircrewRepository => _aircrewRepository ?? 
                                                         (_aircrewRepository = new Repository<Aircrew>(_appContext));

        public IRepository<Pilot> PilotRepository => _pilotRepository ??
                                                     (_pilotRepository = new Repository<Pilot>(_appContext));

        public IRepository<Plane> PlaneRepository => _planeRepository ??
                                                     (_planeRepository = new Repository<Plane>(_appContext));

        public IRepository<PlaneType> PlaneTypeRepository => _planeTypeRepository ??
                                                             (_planeTypeRepository = new Repository<PlaneType>(_appContext));

        public IRepository<Steward> StewardRepository => _stewardRepository ??
                                                         (_stewardRepository = new Repository<Steward>(_appContext));

        public IRepository<Ticket> TicketRepository => _ticketRepository ??
                                                       (_ticketRepository = new Repository<Ticket>(_appContext));

        public void Save()
        {
            _appContext.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _appContext.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
