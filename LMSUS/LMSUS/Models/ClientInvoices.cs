using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ClientInvoices
    {
        public ClientInvoices()
        {
            ClientTranMaster = new HashSet<ClientTranMaster>();
        }

        public decimal Cid { get; set; }
        public decimal Amount { get; set; }
        public decimal Posted { get; set; }
        public decimal UnPosted { get; set; }
        public decimal Balance { get; set; }
        public bool InvoiceStatus { get; set; }
        public long DocId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? PreBalance { get; set; }
        public decimal? Payments { get; set; }
        public decimal? NewCharges { get; set; }
        public decimal? BalanceDue { get; set; }

        public BDoctor Doc { get; set; }
        public ICollection<ClientTranMaster> ClientTranMaster { get; set; }
    }
}
