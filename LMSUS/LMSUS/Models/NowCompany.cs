using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowCompany
    {
        public long CompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Fax { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int IsDeleted { get; set; }
    }
}
