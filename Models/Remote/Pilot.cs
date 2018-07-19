using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Remote
{
    public class Pilot : Person
    {
        public int Exp { get; set; }

        public override string ToString()
        {
            return $"Pilot {Id}: {FirstName}, {LastName}, {BirthDate.ToShortDateString()}, {Exp}";
        }
    }
}
