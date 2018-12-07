using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowState
    {
        public NowState()
        {
            NowProductcustomeraddress = new HashSet<NowProductcustomeraddress>();
        }

        public long StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowProductcustomeraddress> NowProductcustomeraddress { get; set; }
    }
}
