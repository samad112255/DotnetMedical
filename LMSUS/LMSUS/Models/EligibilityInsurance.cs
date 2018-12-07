using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class EligibilityInsurance
    {
        public long EligibilityInsuranceId { get; set; }
        public string PayerName { get; set; }
        public string PayerId { get; set; }
        public string EligibilityRule { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public long? InsId { get; set; }
        public string InsCode { get; set; }
        public bool? Status { get; set; }
    }
}
