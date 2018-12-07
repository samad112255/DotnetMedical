using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ZipCodenew
    {
        public long ZipId { get; set; }
        public string ZipCode { get; set; }
        public long CityId { get; set; }
        public string CityName { get; set; }
        public long? StId { get; set; }
        public string StName { get; set; }
        public string StFullName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
