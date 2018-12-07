using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsurnaceRequestSubscriber
    {
        public long EligibilityRequestSuscriberId { get; set; }
        public long? EligibilityRequestMainId { get; set; }
        public string ReferenceIdentification { get; set; }
        public string OriginatingCompanyIdentifier { get; set; }
        public string ReferenceIdentification2 { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string AddressInformation1 { get; set; }
        public string AddressInformation2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Gender { get; set; }
        public bool? IsDependent { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsLocked { get; set; }
        public long? LockedBy { get; set; }
    }
}
