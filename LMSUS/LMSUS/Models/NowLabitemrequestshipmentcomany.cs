using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitemrequestshipmentcomany
    {
        public NowLabitemrequestshipmentcomany()
        {
            NowLabitemrequestdetail = new HashSet<NowLabitemrequestdetail>();
        }

        public long LabItemRequestShipmentComanyId { get; set; }
        public string ShipmentCompanyName { get; set; }
        public string ShipmentWebsite { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowLabitemrequestdetail> NowLabitemrequestdetail { get; set; }
    }
}
