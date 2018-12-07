using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseEbidentification
    {
        public long EligibilityEbidentificationId { get; set; }
        public long EligibilityResponseSuscriberEbid { get; set; }
        public string ReferenceIdentificationName { get; set; }
        public string ReferenceIdentification { get; set; }
        public string Description { get; set; }
    }
}
