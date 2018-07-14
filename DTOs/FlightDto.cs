using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class FlightDto : BaseDto
    {
        public string DeparturePlace { get; set; }

        public DateTime DepartureTime { get; set; }
      
        public string ArrivalPlace { get; set; }

        public DateTime ArrivalTime { get; set; }

        public IEnumerable<TicketDto> Tickets { get; set; }
    }
}
