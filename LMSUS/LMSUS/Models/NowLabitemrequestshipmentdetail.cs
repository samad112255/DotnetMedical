using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitemrequestshipmentdetail
    {
        public long LabItemRequestShipmentDetailId { get; set; }
        public decimal EventCode { get; set; }
        public DateTime? EventDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string EventDescription { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? LabitemrequestdetailId { get; set; }

        public NowLabitemrequestdetail Labitemrequestdetail { get; set; }
    }
}
