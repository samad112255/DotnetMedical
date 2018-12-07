using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class BillOnlyTest
    {
        public long TestId { get; set; }
        public long? TestCode { get; set; }
        public string TestName { get; set; }
        public string Description { get; set; }
        public string PaymentType { get; set; }
    }
}
