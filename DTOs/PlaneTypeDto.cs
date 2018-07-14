using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class PlaneTypeDto : BaseDto
    {
        public string Model { get; set; }

        public int Places { get; set; }

        public int Carrying { get; set; }
    }
}
