using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Edisubmission
    {
        public long EdiId { get; set; }
        public string InsCode { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? SubmissionTime { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? NoOfPatients { get; set; }
        public int? NoOfClaims { get; set; }
        public decimal? TotalAmount { get; set; }
        public string ControlNumber { get; set; }
        public string EmdeonFileReference { get; set; }
    }
}
