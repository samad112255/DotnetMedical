using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqTestE
    {
        public long PrtId { get; set; }
        public long? PreId { get; set; }
        public long? TgpsId { get; set; }
        public string TgpsType { get; set; }
        public string PrtType { get; set; }
        public string TgpsCode { get; set; }
        public string TgpsName { get; set; }
        public bool? IsTubeReceived { get; set; }
        public string Action { get; set; }
        public DateTime? Date { get; set; }
    }
}
