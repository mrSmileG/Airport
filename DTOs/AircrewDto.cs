using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class AircrewDto
    {
        public int Id { get; set; }

        public PilotDto Pilot { get; set; }

        public IEnumerable<StewardDto> Stewards { get; set; }
    }
}
