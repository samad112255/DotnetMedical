using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowProductcatspecvalue
    {
        public long ProductCatSpecValueId { get; set; }
        public long ProductId { get; set; }
        public long ProductCategorySpecId { get; set; }
        public string SpecValue { get; set; }
        public long CategoryId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
    }
}
