using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowPatwebreqbatch
    {
        public NowPatwebreqbatch()
        {
            NowPatwebreq = new HashSet<NowPatwebreq>();
        }

        public long PatWebReqBatchId { get; set; }
        public string PwrbbatchNumber { get; set; }
        public int PwrbisOpen { get; set; }
        public long PwrbcategoryId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public NowCategory Pwrbcategory { get; set; }
        public ICollection<NowPatwebreq> NowPatwebreq { get; set; }
    }
}
