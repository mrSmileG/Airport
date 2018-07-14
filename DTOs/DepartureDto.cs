using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class DepartureDto : BaseDto
    {
        public Guid FlightId { get; set; }

        public DateTime Date { get; set; }

        public AircrewDto Aircrew { get; set; }

        public PlaneDto Plane { get; set; }
    }
}
