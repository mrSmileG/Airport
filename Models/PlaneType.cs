using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class PlaneType : BaseModel
    {
        [StringLength(50, ErrorMessage = "Incorrect Model string length. It should be between 2 and 50 symbols ", MinimumLength = 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Model is required")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Places count is required")]
        public int Places { get; set; }

        [Required(ErrorMessage = "Carrying is required")]
        public int Carrying { get; set; }
    }
}
