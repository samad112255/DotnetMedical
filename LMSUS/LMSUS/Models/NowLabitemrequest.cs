using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitemrequest
    {
        public NowLabitemrequest()
        {
            NowLabitemrequestdetail = new HashSet<NowLabitemrequestdetail>();
        }

        public long LabItemRequestId { get; set; }
        public long ClientAddressId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long LabItemRequestStatusId { get; set; }
        public long CategoryId { get; set; }
        public long ClientId { get; set; }

        public NowCategory Category { get; set; }
        public NowClient Client { get; set; }
        public NowLabitemclientaddress ClientAddress { get; set; }
        public NowLabitemrequeststatus LabItemRequestStatus { get; set; }
        public ICollection<NowLabitemrequestdetail> NowLabitemrequestdetail { get; set; }
    }
}
