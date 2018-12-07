using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowProductcategory
    {
        public NowProductcategory()
        {
            NowProduct = new HashSet<NowProduct>();
        }

        public long ProductCategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowProduct> NowProduct { get; set; }
    }
}
