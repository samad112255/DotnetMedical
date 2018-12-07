using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InvoiceInsurance
    {
        public long InvoiceId { get; set; }
        public decimal InsId { get; set; }
        public string TypeOfInsurance { get; set; }

        public BInsurance Ins { get; set; }
        public InvoiceMaster Invoice { get; set; }
    }
}
