using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InvoicePatientInsurance
    {
        public decimal PatRelationId { get; set; }
        public long InvoiceId { get; set; }
        public string InsuredLastName { get; set; }
        public string InsuredFirstName { get; set; }
        public string PatSignature { get; set; }
        public string Assignment1 { get; set; }
        public string InsuredSex { get; set; }
        public string DeathIndicarot { get; set; }
        public string InsuredRelationship { get; set; }
        public string Privacy { get; set; }
        public string InsuredGroupNo { get; set; }
        public string PartBBlood { get; set; }
        public string ExtInsNo { get; set; }
        public string PurchaseDg { get; set; }
        public string EmpRelated { get; set; }
        public string CrnaIndicator { get; set; }
        public string AccCode { get; set; }
        public string HomeBoundInd { get; set; }
        public string FamPlanning { get; set; }
        public string Epsdt { get; set; }
        public string PriorAuthNumber { get; set; }
        public string InsuranceName { get; set; }
        public string Address { get; set; }
        public string Icity { get; set; }
        public string Istate { get; set; }
        public string Izip { get; set; }
        public string TelephoneNumber { get; set; }

        public InvoiceMaster Invoice { get; set; }
    }
}
