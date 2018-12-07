using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Hl7Zps
    {
        public long Hzid { get; set; }
        public string PreAccno { get; set; }
        public long? PreId { get; set; }
        public string LabCode { get; set; }
        public string LabName { get; set; }
        public string DirName { get; set; }
        public string LabAddress { get; set; }
        public string LabPhone { get; set; }
        public string SpecimenNumber { get; set; }
    }
}
