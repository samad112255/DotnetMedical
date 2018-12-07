using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class LabTestMapping
    {
        public long RefId { get; set; }
        public string LabId { get; set; }
        public string LabCode { get; set; }
        public string Nsmlcode { get; set; }
        public string TestNameQdx { get; set; }
    }
}
