using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Ticket : BaseModel
    {
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
    }
}
