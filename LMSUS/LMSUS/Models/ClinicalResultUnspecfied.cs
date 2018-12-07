using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ClinicalResultUnspecfied
    {
        public long CrId { get; set; }
        public long? PrtId { get; set; }
        public long? TestId { get; set; }
        public string TestResult { get; set; }
        public string TestStatus { get; set; }
        public string CommentIds { get; set; }
        public string Comments { get; set; }
        public bool? Verified { get; set; }
        public string HighRange { get; set; }
        public string LowRange { get; set; }
        public string NormalRange { get; set; }
        public string ReportDate { get; set; }
        public string PrtIds { get; set; }
        public long PreId { get; set; }
        public string TestResultTodelelete { get; set; }
        public long? PreAccNo { get; set; }
        public DateTime PreAccDate { get; set; }
        public DateTime? ResultDate { get; set; }
        public int? Orderby { get; set; }
        public bool? IsLabcorp { get; set; }
        public string Lab { get; set; }
        public string Status { get; set; }
        public bool? Isreviewed { get; set; }
        public string LabPerformed { get; set; }
        public string Lab2 { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string ResultTestCode { get; set; }
        public string ResultTestName { get; set; }
        public string ResultUnit { get; set; }
    }
}
