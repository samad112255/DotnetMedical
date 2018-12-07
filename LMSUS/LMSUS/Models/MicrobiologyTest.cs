using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class MicrobiologyTest
    {
        public long TestId { get; set; }
        public long? TestCode { get; set; }
        public string TestName { get; set; }
        public long? ClId { get; set; }
        public long? OrgBillTest { get; set; }
        public long? SenBillTest { get; set; }
        public string Source { get; set; }
        public bool? Commissionable { get; set; }
        public string Tube { get; set; }
    }
}
