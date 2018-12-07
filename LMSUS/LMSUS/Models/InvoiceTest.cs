using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InvoiceTest
    {
        public decimal InvoiceTestId { get; set; }
        public long InvoiceId { get; set; }
        public decimal? TestCode { get; set; }
        public string TestName { get; set; }
        public string CptCode { get; set; }
        public string Unt { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Balance { get; set; }
        public string Dx { get; set; }
        public string BillTo { get; set; }
        public string St { get; set; }
        public DateTime? DateBilled { get; set; }
        public string Pre { get; set; }

        public InvoiceMaster Invoice { get; set; }
    }
}
