using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ReportSetup
    {
        public ReportSetup()
        {
            ReportTest = new HashSet<ReportTest>();
        }

        public long ReportId { get; set; }
        public string ReportName { get; set; }

        public ICollection<ReportTest> ReportTest { get; set; }
    }
}
