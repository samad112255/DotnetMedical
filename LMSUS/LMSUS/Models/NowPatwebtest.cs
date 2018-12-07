using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowPatwebtest
    {
        public long ReqTestId { get; set; }
        public long? ReqId { get; set; }
        public long? TestId { get; set; }

        public NowPatwebreq Req { get; set; }
    }
}
