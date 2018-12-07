using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Profile
    {
        public Profile()
        {
            ProfileDetail = new HashSet<ProfileDetail>();
        }

        public long ProId { get; set; }
        public decimal? ProCode { get; set; }
        public string ProName { get; set; }
        public string ProDescription { get; set; }
        public string Status { get; set; }
        public bool? IsSendOutTest { get; set; }
        public bool? IsGetInnerTest { get; set; }

        public ICollection<ProfileDetail> ProfileDetail { get; set; }
    }
}
