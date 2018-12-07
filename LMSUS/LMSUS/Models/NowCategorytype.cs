using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowCategorytype
    {
        public NowCategorytype()
        {
            NowCategory = new HashSet<NowCategory>();
        }

        public long CategoryTypeId { get; set; }
        public string CategoryTypeName { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowCategory> NowCategory { get; set; }
    }
}
