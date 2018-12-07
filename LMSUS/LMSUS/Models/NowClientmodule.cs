using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowClientmodule
    {
        public long ClientModuleId { get; set; }
        public long ClientId { get; set; }
        public long ModuleId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public NowClient Client { get; set; }
        public NowModule Module { get; set; }
    }
}
