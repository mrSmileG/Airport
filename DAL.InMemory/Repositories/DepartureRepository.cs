using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal class DepartureRepository : BaseRepository<Departure>
    {
        public DepartureRepository(AppContext appContext) : base(appContext)
        {
        }

        public override Departure Create(Departure departure)
        {
            _appContext.Departures.Add(departure);
            var dp = _appContext.Departures.Find(d => d.Equals(departure));
            return dp;
        }

        public override void Delete(Guid id)
        {
            var departure = _appContext.Departures.Find(d => d.Id == id);
            if (departure != null)
                _appContext.Departures.Remove(departure);
        }

        public override Departure Get(Guid id)
        {
            return _appContext.Departures.Find(d => d.Id == id);
        }

        public override IEnumerable<Departure> GetList()
        {
            return _appContext.Departures;
        }

        public override void Update(Departure departure)
        {
            var entity = _appContext.Departures.Find(a => a.Id == departure.Id);

            if (entity != null)
            {
                entity.FlightId = departure.FlightId;
                entity.Aircrew = departure.Aircrew;
                entity.Date = departure.Date;
                entity.Plane = departure.Plane;
            }
        }
    }
}
