using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowProductcategoryspec
    {
        public long ProductCategorySpecId { get; set; }
        public long CategoryId { get; set; }
        public string ProductSpecification { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
    }
}
