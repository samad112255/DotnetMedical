using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class BInsurance
    {
        public BInsurance()
        {
            InsTranMaster = new HashSet<InsTranMaster>();
            InvoiceInsurance = new HashSet<InvoiceInsurance>();
        }

        public decimal InsId { get; set; }
        public string InsCode { get; set; }
        public string InsName { get; set; }
        public string InsAddress { get; set; }
        public string InsPhone { get; set; }
        public string InsFax { get; set; }
        public string InsEmail { get; set; }
        public string InsContactPerson { get; set; }
        public decimal? ZipId { get; set; }
        public decimal? FormType { get; set; }
        public decimal? PriceIndex { get; set; }
        public decimal? Discount { get; set; }
        public string IdNo { get; set; }
        public string SubmitterId { get; set; }
        public string Ucf { get; set; }
        public string Emc { get; set; }
        public string Tos { get; set; }
        public string Ucf1 { get; set; }
        public string Emc1 { get; set; }
        public bool? Assign { get; set; }
        public string Remarks { get; set; }
        public bool? RelatDcode { get; set; }
        public bool? ForceHoldNdr { get; set; }
        public string PayorOrgId { get; set; }
        public bool? ReFname { get; set; }
        public bool? ReLname { get; set; }
        public bool? ReDob { get; set; }
        public bool? ReSex { get; set; }
        public bool? ReAddress { get; set; }
        public bool? ReDiag { get; set; }
        public bool? ReInsId { get; set; }
        public string ReInsIdLen { get; set; }
        public bool? ReGroup { get; set; }
        public string ReGroupLen { get; set; }
        public bool? ReDocUpin { get; set; }
        public bool? ReDocLic { get; set; }
        public bool? ReDocMcd { get; set; }
        public bool? ReDocMcr { get; set; }
        public string RePatSignText { get; set; }
        public string ReDosCollege { get; set; }
        public string OtherId { get; set; }

        public ICollection<InsTranMaster> InsTranMaster { get; set; }
        public ICollection<InvoiceInsurance> InvoiceInsurance { get; set; }
    }
}
