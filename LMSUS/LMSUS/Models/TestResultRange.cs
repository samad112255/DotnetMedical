using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class TestResultRange
    {
        public long PkId { get; set; }
        public long? TestId { get; set; }
        public int? AgeFrom { get; set; }
        public int? AgeTo { get; set; }
        public string Type { get; set; }
        public string MHigh { get; set; }
        public string MNormal { get; set; }
        public string MLow { get; set; }
        public string FHigh { get; set; }
        public string FNormal { get; set; }
        public string FLow { get; set; }

        public ClinicalTest Test { get; set; }
    }
}
