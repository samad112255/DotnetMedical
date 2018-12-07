using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseMain
    {
        public long EligibilityResponseMainId { get; set; }
        public long EligibilityRequestMainId { get; set; }
        public long? EmrappointmentId { get; set; }
        public long? PatientDemographicsId { get; set; }
        public string OriginalMessage { get; set; }
        public string ReturnedMessage { get; set; }
        public string PocparticipantId { get; set; }
        public string SurescriptsParticipantId { get; set; }
        public DateTime? InterchangeDate { get; set; }
        public DateTime? InterchangeTime { get; set; }
        public long? InterchangeControlNumber { get; set; }
        public string UsageIndicator { get; set; }
        public long? GroupControlNumber { get; set; }
        public int? ResponseType { get; set; }
        public string ResponseMessage { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsLocked { get; set; }
        public long? LockedBy { get; set; }
        public long? ServerId { get; set; }
        public bool? IsSuccess { get; set; }
    }
}
