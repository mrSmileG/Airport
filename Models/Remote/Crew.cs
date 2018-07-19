using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Remote
{
    public class Crew : BaseModel
    {
        public IEnumerable<Pilot> Pilot { get; set; }

        public IEnumerable<Stewardess> Stewardess { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var pilot in Pilot)
            {
                sb.AppendLine(pilot.ToString());
            }

            foreach (var stewardess in Stewardess)
            {
                sb.AppendLine(stewardess.ToString());
            }

            return $"Crew {Id}:\n{sb}";
        }
    }
}
