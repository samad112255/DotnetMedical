using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class EdisubmissionDetail
    {
        public long EdiDetailId { get; set; }
        public long? EdiId { get; set; }
        public decimal? ClaimId { get; set; }
        public string PatientName { get; set; }
        public string InsId { get; set; }
        public DateTime? ServiceDate { get; set; }
        public int? NoOfService { get; set; }
        public string PricedCode { get; set; }
        public string Diagnosis { get; set; }
        public decimal? AmountCharged { get; set; }
        public string ReferringPhysician { get; set; }
        public string TestType { get; set; }
    }
}
