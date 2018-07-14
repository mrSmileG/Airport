using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTOs
{
    public class PilotDto : PersonDto
    {
        [Required]
        public int Experience { get; set; }
    }
}
