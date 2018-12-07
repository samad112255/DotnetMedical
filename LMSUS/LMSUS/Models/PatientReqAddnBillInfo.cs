using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqAddnBillInfo
    {
        public long PrAbiId { get; set; }
        public long PreId { get; set; }
        public string InsCode { get; set; }
        public string InsdLastName { get; set; }
        public string InsdFirstName { get; set; }
        public string InsdSex { get; set; }
        public string InsdAddress { get; set; }
        public string InsdPhone { get; set; }
        public long? InsdRelationship { get; set; }
        public string InsdGroupNo { get; set; }
        public string ExtraInsuranceNo { get; set; }
        public string EmploymentRel { get; set; }
        public string AccidentCode { get; set; }
        public string FamilyPlanning { get; set; }
        public DateTime? DeceasedDate { get; set; }
        public string PriorAuth { get; set; }
        public string PatientSign { get; set; }
        public string AssignAccpt { get; set; }
        public string BenefitAssigned { get; set; }
        public string Privacy { get; set; }
        public string PatSignSource { get; set; }
        public string SpecProgCode { get; set; }
        public string DelayReason { get; set; }
        public string HomeBoundInd { get; set; }
        public string Emergency { get; set; }
        public DateTime? EmergDate { get; set; }
        public string Epsdt { get; set; }
        public string St { get; set; }
        public decimal? ZipId { get; set; }
        public string InsSsn { get; set; }
        public DateTime? InsDob { get; set; }

        public Relations InsdRelationshipNavigation { get; set; }
        public PatientReq Pre { get; set; }
    }
}
