using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ClinicalResultComm
    {
        public long CrcId { get; set; }
        public long? CrId { get; set; }
        public long? ComId { get; set; }
        public string ComDescription { get; set; }

        public Comments Com { get; set; }
        public ClinicalResult Cr { get; set; }
    }
}
