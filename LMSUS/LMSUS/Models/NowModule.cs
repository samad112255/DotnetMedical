using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowModule
    {
        public NowModule()
        {
            NowCategorymodule = new HashSet<NowCategorymodule>();
            NowClientmodule = new HashSet<NowClientmodule>();
        }

        public long ModulesId { get; set; }
        public string ModuleName { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowCategorymodule> NowCategorymodule { get; set; }
        public ICollection<NowClientmodule> NowClientmodule { get; set; }
    }
}
