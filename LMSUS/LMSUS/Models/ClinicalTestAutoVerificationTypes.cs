using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ClinicalTestAutoVerificationTypes
    {
        public ClinicalTestAutoVerificationTypes()
        {
            ClinicalTest = new HashSet<ClinicalTest>();
        }

        public long ResultVerificationTypeId { get; set; }
        public string VerificationType { get; set; }

        public ICollection<ClinicalTest> ClinicalTest { get; set; }
    }
}
