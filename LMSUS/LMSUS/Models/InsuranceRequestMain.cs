using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceRequestMain
    {
        public long EligibilityRequestMainId { get; set; }
        public long? PatientDemographicsId { get; set; }
        public string OriginalMessage { get; set; }
        public string ReturnedMessage { get; set; }
        public string PocparticipantId { get; set; }
        public string EmdeonUserId { get; set; }
        public DateTime? InterchangeDate { get; set; }
        public string InterchangeControlNumber { get; set; }
        public string GroupControlNumber { get; set; }
        public string BeginingHeaderNumber { get; set; }
        public long? EmrproviderId { get; set; }
        public long? PatientVisitDetailId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsLocked { get; set; }
        public long? LockedBy { get; set; }
        public bool? Successed { get; set; }
        public long? ServerId { get; set; }
        public int? ResponseType { get; set; }
        public string ErrorDescription { get; set; }
        public long? InsuranceProviderOrganizationId { get; set; }
        public long? EligibilityInsuranceId { get; set; }
    }
}
