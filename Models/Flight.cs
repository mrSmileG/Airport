using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Flight : BaseModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Departure Place is required")]
        [MinLength(3, ErrorMessage = "Departure Place length must be greater or equal then 3 symbols")]
        public string DeparturePlace { get; set; }

        [Required(ErrorMessage = "Departure time is required")]
        public DateTime DepartureTime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Arrival Place is required")]
        [MinLength(3, ErrorMessage = "Arrival Place length must be greater or equal then 3 symbols")]
        public string ArrivalPlace { get; set; }

        [Required(ErrorMessage = "Arrival time is required")]
        public DateTime ArrivalTime { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
