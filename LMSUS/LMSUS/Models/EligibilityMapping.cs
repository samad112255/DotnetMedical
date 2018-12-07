using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class EligibilityMapping
    {
        public long EligibilityMappingId { get; set; }
        public long EligibilityInsuranceId { get; set; }
        public long InsId { get; set; }
        public bool? Status { get; set; }
    }
}
