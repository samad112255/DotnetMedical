using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitemsupplierdetail
    {
        public long LabItemSupplierDetail { get; set; }
        public long LabItemId { get; set; }
        public long LabItemSupplierId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public NowLabitem LabItem { get; set; }
        public NowLabitemsupplier LabItemSupplier { get; set; }
    }
}
