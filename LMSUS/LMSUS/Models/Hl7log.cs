using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Hl7log
    {
        public long Hl7logId { get; set; }
        public DateTime? DateHl7Generated { get; set; }
        public string Hl7string { get; set; }
        public string AccessionNosInHl7 { get; set; }
        public long? PreAccNo { get; set; }
        public string Hl7filePath { get; set; }
        public bool? IsPartial { get; set; }
        public bool? IsFinal { get; set; }
    }
}
