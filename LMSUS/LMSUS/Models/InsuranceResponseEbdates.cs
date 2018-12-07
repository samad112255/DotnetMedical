using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseEbdates
    {
        public long EligibilityEbidateId { get; set; }
        public long EligibilityResponseSuscriberEbid { get; set; }
        public string DateType { get; set; }
        public string DateDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Enddate { get; set; }
    }
}
