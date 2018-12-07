using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ClientTranMaster
    {
        public decimal CtmId { get; set; }
        public decimal BatchId { get; set; }
        public decimal? Cid { get; set; }
        public decimal? InvoiceId { get; set; }
        public decimal? InvoiceTestId { get; set; }
        public long DocId { get; set; }
        public long? Tid { get; set; }
        public decimal? Payment { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? RecDate { get; set; }
        public string ChequeNo { get; set; }
        public string Reference { get; set; }
        public string ApplyMethod { get; set; }

        public BatchMaster Batch { get; set; }
        public ClientInvoices C { get; set; }
        public BDoctor Doc { get; set; }
        public TransactionType T { get; set; }
    }
}
