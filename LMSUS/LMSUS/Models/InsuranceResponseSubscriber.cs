using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseSubscriber
    {
        public long EligibilityResponseSuscriberId { get; set; }
        public long? EligibilityResponseDetailId { get; set; }
        public long? EligibilityResponseMainId { get; set; }
        public string Trace1 { get; set; }
        public string Trace1ReferenceIdentification { get; set; }
        public string Trace1OriginatingCompanyIdentifier { get; set; }
        public string Trace1ReferenceIdentification2 { get; set; }
        public string Trace2 { get; set; }
        public string Trace2ReferenceIdentification { get; set; }
        public string Trace2OriginatingCompanyIdentifier { get; set; }
        public string Trace2ReferenceIdentification2 { get; set; }
        public string Trace3 { get; set; }
        public string Trace3ReferenceIdentification { get; set; }
        public string Trace3OriginatingCompanyIdentifier { get; set; }
        public string Trace3ReferenceIdentification2 { get; set; }
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
        public string ProviderDescription { get; set; }
        public string ProviderReferenceIdentificationDescription { get; set; }
        public string ProviderReferenceIdentification { get; set; }
        public bool? IsChanged { get; set; }
        public string BenifitStatusCode { get; set; }
        public string MedicareStatusCode { get; set; }
        public string ConsolidatedStatus { get; set; }
        public string StudentStatus { get; set; }
        public DateTime? InsdateTime { get; set; }
        public string ConfidentialyCode { get; set; }
        public string InsCity { get; set; }
        public string InsState { get; set; }
        public string InsCountry { get; set; }
        public string InsNumber { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsLocked { get; set; }
        public long? LockedBy { get; set; }
        public string Relation { get; set; }
    }
}
