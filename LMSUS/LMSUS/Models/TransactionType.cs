using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            ClientTranMaster = new HashSet<ClientTranMaster>();
            InsTranMaster = new HashSet<InsTranMaster>();
        }

        public long Tid { get; set; }
        public string TransCode { get; set; }
        public string TransType { get; set; }
        public string Description { get; set; }

        public ICollection<ClientTranMaster> ClientTranMaster { get; set; }
        public ICollection<InsTranMaster> InsTranMaster { get; set; }
    }
}
