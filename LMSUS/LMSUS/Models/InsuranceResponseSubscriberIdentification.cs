using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseSubscriberIdentification
    {
        public long EligibilitySubscriberIdentificationId { get; set; }
        public long EligibilityResponseSuscriberId { get; set; }
        public string ReferenceIdentificationName { get; set; }
        public string ReferenceIdentification { get; set; }
        public string Description { get; set; }
    }
}
