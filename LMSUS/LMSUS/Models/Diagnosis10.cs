using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Diagnosis10
    {
        public Diagnosis10()
        {
            TestRelatedDiag10 = new HashSet<TestRelatedDiag10>();
            TestRelatedDiag101 = new HashSet<TestRelatedDiag101>();
        }

        public long DiaId { get; set; }
        public string DiaCode { get; set; }
        public string DiaName { get; set; }

        public ICollection<TestRelatedDiag10> TestRelatedDiag10 { get; set; }
        public ICollection<TestRelatedDiag101> TestRelatedDiag101 { get; set; }
    }
}
