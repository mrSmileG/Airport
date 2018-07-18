using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public abstract class Person : BaseModel
    {
        [StringLength(50, ErrorMessage = "Incorrect Name string length. It should be between 2 and 50 symbols ", MinimumLength = 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Incorrect Surname string length. It should be between 2 and 50 symbols ", MinimumLength = 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        public DateTime Birth { get; set; }
    }
}
