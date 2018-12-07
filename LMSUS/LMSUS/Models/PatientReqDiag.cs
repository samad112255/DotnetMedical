using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqDiag
    {
        public long PreDiagId { get; set; }
        public long PreId { get; set; }
        public long? DiaId { get; set; }
        public long? DiaId10 { get; set; }

        public Diagnosis Dia { get; set; }
        public PatientReq Pre { get; set; }
    }
}
