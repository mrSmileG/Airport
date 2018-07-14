using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTOs
{
    public abstract class PersonDto : BaseDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birth { get; set; }
    }
}
