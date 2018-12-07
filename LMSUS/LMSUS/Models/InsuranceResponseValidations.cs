using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseValidations
    {
        public long EligibilityResposeValidationId { get; set; }
        public long? Position { get; set; }
        public string ResponseCode { get; set; }
        public long? RejectReasonCode { get; set; }
        public string FollowupActionCode { get; set; }
        public string FollowupActionDescription { get; set; }
        public long? EligibilityResponseDetailId { get; set; }
    }
}
