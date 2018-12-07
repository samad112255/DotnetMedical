using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class CytologyTest
    {
        public CytologyTest()
        {
            PatCyto = new HashSet<PatCyto>();
        }

        public long CtId { get; set; }
        public string TestNo { get; set; }
        public string TestName { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public long? ClId { get; set; }

        public RefClinicLab Cl { get; set; }
        public ICollection<PatCyto> PatCyto { get; set; }
    }
}
