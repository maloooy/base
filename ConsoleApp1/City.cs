using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class City
    {
        public City()
        {
            Clubs = new HashSet<Club>();
        }

        public long CityId { get; set; }
        public string? Title { get; set; }
        public string? State { get; set; }
        public long? Population { get; set; }

        public virtual ICollection<Club> Clubs { get; set; }
    }
}
