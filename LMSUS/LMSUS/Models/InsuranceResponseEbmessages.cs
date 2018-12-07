using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseEbmessages
    {
        public long EligibilityEbimessageId { get; set; }
        public long EligibilityResponseSuscriberEbid { get; set; }
        public string Message { get; set; }
    }
}
