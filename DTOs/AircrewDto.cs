using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class AircrewDto : BaseDto
    {
        public PilotDto Pilot { get; set; }

        public IEnumerable<StewardDto> Stewards { get; set; }
    }
}
