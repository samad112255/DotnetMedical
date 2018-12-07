using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitemrequestdetail
    {
        public NowLabitemrequestdetail()
        {
            NowLabitemrequestshipmentdetail = new HashSet<NowLabitemrequestshipmentdetail>();
        }

        public long LabItemRequestDetailId { get; set; }
        public long LabItemId { get; set; }
        public int Quantity { get; set; }
        public int Approved { get; set; }
        public long? LabItemSupplierId { get; set; }
        public int? Shipped { get; set; }
        public int? DestinationReached { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long LabItemRequestId { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Weight { get; set; }
        public long? LabItemRequestShipmentCompanyId { get; set; }

        public NowLabitem LabItem { get; set; }
        public NowLabitemrequest LabItemRequest { get; set; }
        public NowLabitemrequestshipmentcomany LabItemRequestShipmentCompany { get; set; }
        public NowLabitemsupplier LabItemSupplier { get; set; }
        public ICollection<NowLabitemrequestshipmentdetail> NowLabitemrequestshipmentdetail { get; set; }
    }
}
