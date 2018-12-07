using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class CompletedReport
    {
        public long Id { get; set; }
        public string PreAccno { get; set; }
        public bool? Status { get; set; }
        public DateTime? PrintDate { get; set; }
    }
}
