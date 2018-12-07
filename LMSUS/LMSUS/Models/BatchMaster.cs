using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class BatchMaster
    {
        public BatchMaster()
        {
            ClientTranMaster = new HashSet<ClientTranMaster>();
            InsTranMaster = new HashSet<InsTranMaster>();
        }

        public decimal BatchId { get; set; }
        public string BatchNumber { get; set; }
        public string BatchType { get; set; }
        public string BatchStatus { get; set; }
        public DateTime? BatchDate { get; set; }
        public DateTime? PostDate { get; set; }
        public string AccNo { get; set; }
        public string Icn { get; set; }

        public ICollection<ClientTranMaster> ClientTranMaster { get; set; }
        public ICollection<InsTranMaster> InsTranMaster { get; set; }
    }
}
