using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InhouseLabTestMapping
    {
        public long IhmapId { get; set; }
        public string ClCode { get; set; }
        public string TestShortName { get; set; }
        public string ValueType { get; set; }
        public decimal? TestId { get; set; }
        public decimal? TestCode { get; set; }
        public string MapTestCode { get; set; }
    }
}
