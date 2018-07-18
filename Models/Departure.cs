using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Departure : BaseModel
    {
        public int FlightId { get; set; }

        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        public int AircrewId { get; set; }

        [ForeignKey("AircrewId")]
        public Aircrew Aircrew { get; set; }

        public int PlaneId { get; set; }

        [ForeignKey("PlaneId")]
        public Plane Plane { get; set; }
    }
}
