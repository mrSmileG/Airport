﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Plane : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name length must be greater or equal then 2 symbols")]
        public string Name { get; set; }

        public int PlaneTypeId { get; set; }
        
        [ForeignKey("PlaneTypeId")]
        public PlaneType Type { get; set; }

        [Required(ErrorMessage = "Release date is required")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Lifetime is required")]
        public TimeSpan Lifetime { get; set; }
    }
}
