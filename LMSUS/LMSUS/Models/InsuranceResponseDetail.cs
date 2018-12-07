using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseDetail
    {
        public long EligibilityResponseDetailId { get; set; }
        public long? EligibilityResponseMainId { get; set; }
        public string TransactionSetControlNumber { get; set; }
        public string ReferenceIdentification { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsLocked { get; set; }
        public long? LockedBy { get; set; }
        public string Eq01 { get; set; }
        public string Eq02 { get; set; }
        public string PayerName { get; set; }
        public string IdentificationType { get; set; }
        public string IdentificationId { get; set; }
        public string ErrorDescription { get; set; }
        public bool? HasSuccess { get; set; }
        public string Entity { get; set; }
        public string EntityType { get; set; }
        public string PerName1 { get; set; }
        public string PerNumberType11 { get; set; }
        public string PerNumber11 { get; set; }
        public string PerNumberType12 { get; set; }
        public string PerNumber12 { get; set; }
        public string PerNumberType13 { get; set; }
        public string PerNumber13 { get; set; }
        public string PerNumber18 { get; set; }
        public string PerName2 { get; set; }
        public string PerNumberType21 { get; set; }
        public string PerNumber21 { get; set; }
        public string PerNumberType22 { get; set; }
        public string PerNumber22 { get; set; }
        public string PerNumberType23 { get; set; }
        public string PerNumber23 { get; set; }
        public string PerNumber28 { get; set; }
        public string PerName3 { get; set; }
        public string PerNumberType31 { get; set; }
        public string PerNumber31 { get; set; }
        public string PerNumberType32 { get; set; }
        public string PerNumber32 { get; set; }
        public string PerNumberType33 { get; set; }
        public string PerNumber33 { get; set; }
        public string PerNumber38 { get; set; }
    }
}
