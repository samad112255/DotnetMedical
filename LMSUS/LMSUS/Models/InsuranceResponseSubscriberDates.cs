using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseSubscriberDates
    {
        public long EligibilitySubscriberDateId { get; set; }
        public long EligibilityResponseSuscriberId { get; set; }
        public string DateType { get; set; }
        public string DateDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Enddate { get; set; }
    }
}
