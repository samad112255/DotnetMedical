using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InvoiceMaster
    {
        public InvoiceMaster()
        {
            InvoiceInsurance = new HashSet<InvoiceInsurance>();
            InvoicePatientInsurance = new HashSet<InvoicePatientInsurance>();
            InvoiceTest = new HashSet<InvoiceTest>();
        }

        public long InvoiceId { get; set; }
        public string AccessionNo { get; set; }
        public DateTime? ServiceDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? PatientId { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string GroupNumber { get; set; }
        public long? ClientId { get; set; }
        public string Comments { get; set; }
        public string Assignment { get; set; }
        public decimal? TotalCharges { get; set; }
        public decimal? Payments { get; set; }
        public decimal? Adjustments { get; set; }
        public decimal? Balance { get; set; }
        public int? CompanyCode { get; set; }
        public string InsId1 { get; set; }
        public string InsId2 { get; set; }
        public string UserId { get; set; }
        public DateTime? ChangeDate { get; set; }

        public BDoctor Client { get; set; }
        public BPatient Patient { get; set; }
        public ICollection<InvoiceInsurance> InvoiceInsurance { get; set; }
        public ICollection<InvoicePatientInsurance> InvoicePatientInsurance { get; set; }
        public ICollection<InvoiceTest> InvoiceTest { get; set; }
    }
}
