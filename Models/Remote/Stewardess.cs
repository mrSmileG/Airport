using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Remote
{
    public class Stewardess : Person
    {
        public override string ToString()
        {
            return $"Stewardess {Id}: {FirstName}, {LastName}, {BirthDate.ToShortDateString()}";
        }
    }
}
