using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ReportTest
    {
        public long RtId { get; set; }
        public long ReportId { get; set; }
        public long TestId { get; set; }
        public int Ord { get; set; }

        public ReportSetup Report { get; set; }
        public ClinicalTest Test { get; set; }
    }
}
