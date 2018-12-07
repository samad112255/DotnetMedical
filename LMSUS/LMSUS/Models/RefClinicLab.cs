using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class RefClinicLab
    {
        public RefClinicLab()
        {
            ClinicalTestRefLabMapping = new HashSet<ClinicalTestRefLabMapping>();
            CytologyTest = new HashSet<CytologyTest>();
        }

        public long ClId { get; set; }
        public string ClCode { get; set; }
        public string ClName { get; set; }
        public string ClAddress { get; set; }
        public string ClPhone { get; set; }
        public string ClFax { get; set; }
        public string ClEmail { get; set; }
        public string ClContactPerson { get; set; }
        public string ClDescription { get; set; }
        public string ClType { get; set; }
        public long? ZipId { get; set; }
        public string ClSign { get; set; }
        public string TestPrefix { get; set; }
        public string AccountNumber { get; set; }
        public string IsDefault { get; set; }
        public string Hl7ResultPath { get; set; }
        public string Hl7OrderPath { get; set; }

        public ICollection<ClinicalTestRefLabMapping> ClinicalTestRefLabMapping { get; set; }
        public ICollection<CytologyTest> CytologyTest { get; set; }
    }
}
