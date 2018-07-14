using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal class FlightRepository : BaseRepository<Flight>
    {

        public FlightRepository(AppContext appContext) : base(appContext)
        {
        }

        public override Flight Create(Flight flight)
        {
            _appContext.Flights.Add(flight);
            var fl = _appContext.Flights.Find(f => f.Equals(flight));
            return fl;
        }

        public override void Delete(Guid id)
        {
            var flight = _appContext.Flights.Find(f => f.Id == id);
            if (flight != null)
                _appContext.Flights.Remove(flight);
        }

        public override Flight Get(Guid id)
        {
            return _appContext.Flights.Find(f => f.Id == id);
        }

        public override IEnumerable<Flight> GetList()
        {
            return _appContext.Flights;
        }

        public override void Update(Flight flight)
        {
            var entity = _appContext.Flights.Find(f => f.Id == flight.Id);

            if (entity != null)
            {
                entity.ArrivalPlace = flight.ArrivalPlace;
                entity.ArrivalTime = flight.ArrivalTime;
                entity.DeparturePlace = flight.DeparturePlace;
                entity.DepartureTime = flight.DepartureTime;
                entity.Tickets = flight.Tickets;
            }
        }
    }
}
