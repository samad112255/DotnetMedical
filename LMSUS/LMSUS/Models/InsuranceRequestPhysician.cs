using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceRequestPhysician
    {
        public long EligibilityRequestPhysicianId { get; set; }
        public long? EligibilityRequestMainId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string EmployeeId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string FederalTaxpayerId { get; set; }
        public string PayerIdentification { get; set; }
        public string PharmacyProcessorNo { get; set; }
        public string ServiceProviderNo { get; set; }
        public string Npi { get; set; }
        public string SubmitterId { get; set; }
        public string Description { get; set; }
        public string StateLicenseNo { get; set; }
        public string MedicareProviderNo { get; set; }
        public string MedicaidProviderNo { get; set; }
        public string FacilityIdnumber { get; set; }
        public string PersonalIdentificationNo { get; set; }
        public string ContractNumber { get; set; }
        public string ElectronicDevicePin { get; set; }
        public string Hpi { get; set; }
        public string UserIdentification { get; set; }
        public string ProviderPlanNetworkId { get; set; }
        public string FacilityNetworkId { get; set; }
        public string PriorIdentifierNumber { get; set; }
        public string StateLicenseNumberDesc { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
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
