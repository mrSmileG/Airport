using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class PlaneDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public PlaneTypeDto Type { get; set; }

        public DateTime ReleaseDate { get; set; }

        public TimeSpan Lifetime { get; set; }
    }
}
