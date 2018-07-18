using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTOs
{
    public class PilotDto
    {
        public int  Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birth { get; set; }

        public int Experience { get; set; }
    }
}
