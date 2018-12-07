using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class City
    {
        public City()
        {
            ZipCode = new HashSet<ZipCode>();
        }

        public long CityId { get; set; }
        public string CityName { get; set; }
        public long? StId { get; set; }

        public State St { get; set; }
        public ICollection<ZipCode> ZipCode { get; set; }
    }
}
