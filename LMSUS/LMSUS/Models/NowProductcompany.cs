using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowProductcompany
    {
        public NowProductcompany()
        {
            NowProduct = new HashSet<NowProduct>();
        }

        public long ProductCompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowProduct> NowProduct { get; set; }
    }
}
