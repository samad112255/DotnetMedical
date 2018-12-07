using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class CompanyProviderId
    {
        public long CompanyPkproviderId { get; set; }
        public long? Pkid { get; set; }
        public long? EligibilityInsuranceId { get; set; }
        public string PayerName { get; set; }
        public string PayerId { get; set; }
        public string PhoneNumber { get; set; }
        public string ProviderId { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
    }
}
