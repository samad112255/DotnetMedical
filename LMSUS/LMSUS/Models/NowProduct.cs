using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowProduct
    {
        public long ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDesc { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long CategoryId { get; set; }
        public long ProductCompanyId { get; set; }
        public string LargImage { get; set; }
        public string SmallImage { get; set; }
        public string Model { get; set; }
        public int? QtyInStock { get; set; }

        public NowProductcategory Category { get; set; }
        public NowProductcompany ProductCompany { get; set; }
    }
}
