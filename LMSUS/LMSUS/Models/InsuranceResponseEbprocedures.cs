using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseEbprocedures
    {
        public long EligibilityEbprocedureId { get; set; }
        public long EligibilityResponseSuscriberEbid { get; set; }
        public string ProcedureCode { get; set; }
        public string ProductServiceId { get; set; }
        public string ProcedureModifier1 { get; set; }
        public string ProcedureModifier2 { get; set; }
        public string ProcedureModifier3 { get; set; }
        public string ProcedureModifier4 { get; set; }
        public string ProcedureDescription { get; set; }
        public string ProductServiceId2 { get; set; }
        public string DxPointer1 { get; set; }
        public string DxPointer2 { get; set; }
        public string DxPointer3 { get; set; }
        public string DxPointer4 { get; set; }
    }
}
