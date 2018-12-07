using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class SuperProfile
    {
        public SuperProfile()
        {
            SuperProfileDetail = new HashSet<SuperProfileDetail>();
        }

        public long SproId { get; set; }
        public long? SproCode { get; set; }
        public string SproName { get; set; }
        public string SproDescription { get; set; }
        public bool? IsSendOutTest { get; set; }
        public bool? IsGetInnerTest { get; set; }

        public ICollection<SuperProfileDetail> SuperProfileDetail { get; set; }
    }
}
