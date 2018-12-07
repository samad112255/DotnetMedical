using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsTranMaster
    {
        public decimal ItmId { get; set; }
        public decimal BatchId { get; set; }
        public decimal InvoiceId { get; set; }
        public decimal? InvoiceTestId { get; set; }
        public decimal InsId { get; set; }
        public long? DocId { get; set; }
        public long Tid { get; set; }
        public decimal? Payment { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? RecDate { get; set; }
        public string ChequeNo { get; set; }
        public string RefNumber { get; set; }
        public string ReasonCode { get; set; }
        public string UserId { get; set; }

        public BatchMaster Batch { get; set; }
        public BDoctor Doc { get; set; }
        public BInsurance Ins { get; set; }
        public TransactionType T { get; set; }
    }
}
