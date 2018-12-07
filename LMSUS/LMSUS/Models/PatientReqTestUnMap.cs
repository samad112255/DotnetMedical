using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqTestUnMap
    {
        public long PrtId { get; set; }
        public long PreId { get; set; }
        public long TgpsId { get; set; }
        public string TgpsType { get; set; }
        public string PrtType { get; set; }
        public string TgpsCode { get; set; }
        public string TgpsName { get; set; }
        public bool? IsTubeReceived { get; set; }
        public string Labperformed { get; set; }
        public bool? Testentered { get; set; }
        public bool? IsTransfer { get; set; }
    }
}
