using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Aircrew : BaseModel
    {
        [Required(ErrorMessage = "Pilot is required")]
        public Pilot Pilot { get; set; }

        [Required(ErrorMessage = "Stewards list is required")]
        public IEnumerable<Steward> Stewards { get; set; }
    }
}
