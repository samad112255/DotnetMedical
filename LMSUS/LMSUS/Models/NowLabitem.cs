using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitem
    {
        public NowLabitem()
        {
            NowLabitemcategory = new HashSet<NowLabitemcategory>();
            NowLabitemrequestdetail = new HashSet<NowLabitemrequestdetail>();
            NowLabitemsupplierdetail = new HashSet<NowLabitemsupplierdetail>();
        }

        public long LabtItemId { get; set; }
        public string ItemName { get; set; }
        public long UnitType { get; set; }
        public int? UnitQty { get; set; }
        public int ItemNumber { get; set; }
        public int? QtyInStock { get; set; }
        public int? MinimuQty { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public NowLabitemunittype UnitTypeNavigation { get; set; }
        public ICollection<NowLabitemcategory> NowLabitemcategory { get; set; }
        public ICollection<NowLabitemrequestdetail> NowLabitemrequestdetail { get; set; }
        public ICollection<NowLabitemsupplierdetail> NowLabitemsupplierdetail { get; set; }
    }
}
