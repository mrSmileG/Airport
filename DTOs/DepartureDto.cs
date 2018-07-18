using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class DepartureDto
    {
        public int Id { get; set; }

        public FlightDto Flight { get; set; }

        public DateTime Date { get; set; }

        public AircrewDto Aircrew { get; set; }

        public PlaneDto Plane { get; set; }
    }
}
