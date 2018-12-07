using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqBillTests
    {
        public long PrbtId { get; set; }
        public long? PreId { get; set; }
        public string BillTo { get; set; }
        public decimal TestId { get; set; }
        public decimal? TestCode { get; set; }
        public string TestDescription { get; set; }
        public string CptCode { get; set; }
        public string Type { get; set; }
        public string TestType { get; set; }
        public decimal? Amount { get; set; }
        public bool? Billable { get; set; }
        public bool Micro { get; set; }

        public PatientReq Pre { get; set; }
    }
}
