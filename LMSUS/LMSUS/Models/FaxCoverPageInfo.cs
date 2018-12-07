using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class FaxCoverPageInfo
    {
        public long FaxCoverPageId { get; set; }
        public string FromMessage { get; set; }
        public string CofidentialMessage { get; set; }
        public string ToMessage { get; set; }
    }
}
