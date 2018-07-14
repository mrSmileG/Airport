using System;
using System.Collections.Generic;
using Models;

namespace DAL.InMemory
{
    public class AppContext
    {

        public AppContext()
        {
            Configuration.Seed(this);
        }

        public List<Aircrew> Aircrews { get; set; }

        public List<Departure> Departures { get; set; }

        public List<Flight> Flights { get; set; }

        public List<Pilot> Pilots { get; set; }

        public List<Plane> Planes { get; set; }

        public List<PlaneType> PlaneTypes { get; set; }

        public List<Steward> Stewards { get; set; }

        public List<Ticket> Tickets { get; set; }

    }
}
