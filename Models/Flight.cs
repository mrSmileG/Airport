using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Flight : BaseModel
    {
        [StringLength(50, ErrorMessage = "Incorrect Departure place string length. It should be between 3 and 50 symbols ", MinimumLength = 3)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Departure place is required")]
        public string DeparturePlace { get; set; }

        [Required(ErrorMessage = "Departure time is required")]
        public DateTime DepartureTime { get; set; }

        [StringLength(50, ErrorMessage = "Incorrect Arrival place string length. It should be between 3 and 50 symbols ", MinimumLength = 3)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Arrival place is required")]
        public string ArrivalPlace { get; set; }

        [Required(ErrorMessage = "Arrival time is required")]
        public DateTime ArrivalTime { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
