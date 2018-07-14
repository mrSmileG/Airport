using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Departure : BaseModel
    {
        [Required(ErrorMessage = "Flight id is required")]
        public Guid FlightId { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Aircrew is required")]
        public Aircrew Aircrew { get; set; }

        [Required(ErrorMessage = "Plane is required")]
        public Plane Plane { get; set; }
    }
}
