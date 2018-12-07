using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseSubscriberEbmain
    {
        public long EligibilityResponseSuscriberEbmainId { get; set; }
        public long? EligibilityResponseSuscriberId { get; set; }
        public string EligibilityTypeCode { get; set; }
        public string EligibilityType { get; set; }
    }
}
