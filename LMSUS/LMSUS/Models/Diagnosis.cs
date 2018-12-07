using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Diagnosis
    {
        public Diagnosis()
        {
            PatientReqDiag = new HashSet<PatientReqDiag>();
            TestRelatedDiag = new HashSet<TestRelatedDiag>();
        }

        public long DiaId { get; set; }
        public string DiaCode { get; set; }
        public string DiaName { get; set; }

        public ICollection<PatientReqDiag> PatientReqDiag { get; set; }
        public ICollection<TestRelatedDiag> TestRelatedDiag { get; set; }
    }
}
