using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ZipCode
    {
        public ZipCode()
        {
            Insurance = new HashSet<Insurance>();
        }

        public long ZipId { get; set; }
        public string ZipCode1 { get; set; }
        public long CityId { get; set; }
        public string CityName { get; set; }
        public long? StId { get; set; }
        public string StName { get; set; }
        public string StFullName { get; set; }
        public bool? IsActive { get; set; }

        public City City { get; set; }
        public ICollection<Insurance> Insurance { get; set; }
    }
}
