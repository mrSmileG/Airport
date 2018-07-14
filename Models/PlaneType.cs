using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class PlaneType : BaseModel
    {
        [Required(ErrorMessage = "Model is required")]
        [MinLength(2, ErrorMessage = "Model length must be greater or equal then 2 symbols")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Places is required")]
        public int Places { get; set; }

        [Required(ErrorMessage = "Carrying is required")]
        public int Carrying { get; set; }
    }
}
