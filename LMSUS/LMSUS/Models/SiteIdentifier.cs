using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class SiteIdentifier
    {
        public long SiteId { get; set; }
        public string ProviderSiteId { get; set; }
        public bool? IsFacility { get; set; }
        public long? Npi { get; set; }
        public string DoctorName { get; set; }
        public string StateLicense { get; set; }
    }
}
