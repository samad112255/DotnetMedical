using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitemsupplier
    {
        public NowLabitemsupplier()
        {
            NowLabitemrequestdetail = new HashSet<NowLabitemrequestdetail>();
            NowLabitemsupplierdetail = new HashSet<NowLabitemsupplierdetail>();
        }

        public long LabItemSupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowLabitemrequestdetail> NowLabitemrequestdetail { get; set; }
        public ICollection<NowLabitemsupplierdetail> NowLabitemsupplierdetail { get; set; }
    }
}
