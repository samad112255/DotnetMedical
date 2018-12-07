using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class GroupTest
    {
        public GroupTest()
        {
            GroupDetail = new HashSet<GroupDetail>();
        }

        public long GrId { get; set; }
        public decimal? GrCode { get; set; }
        public string GrName { get; set; }
        public string GrDescription { get; set; }
        public bool? Commissionable { get; set; }
        public string Tube { get; set; }
        public string Status { get; set; }
        public bool? IsSendOutTest { get; set; }

        public ICollection<GroupDetail> GroupDetail { get; set; }
    }
}
