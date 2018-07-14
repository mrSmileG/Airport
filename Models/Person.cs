using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public abstract class Person : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Name length must be greater or equal then 3 symbols")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [MinLength(3, ErrorMessage = "Surname length must be greater or equal then 3 symbols")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Birth is required")]
        public DateTime Birth { get; set; }
    }
}
