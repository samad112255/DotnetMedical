using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Hl7Zef
    {
        public long ZefId { get; set; }
        public string PreAccno { get; set; }
        public string ReportData { get; set; }
        public string TestId { get; set; }
        public string Pdf { get; set; }
    }
}
