using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class TicketDto
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int FlightId { get; set; }
    }
}
