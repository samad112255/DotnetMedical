using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowCategorymodule
    {
        public long CategoryModuleId { get; set; }
        public long CategoryId { get; set; }
        public long ModuleId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public NowCategory Category { get; set; }
        public NowModule Module { get; set; }
    }
}
