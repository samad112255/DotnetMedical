using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqTest
    {
        public PatientReqTest()
        {
            MicroBiologyResult = new HashSet<MicroBiologyResult>();
        }

        public long PrtId { get; set; }
        public long PreId { get; set; }
        public long TgpsId { get; set; }
        public string TgpsType { get; set; }
        public string PrtType { get; set; }
        public long TgpsCode { get; set; }
        public string TgpsName { get; set; }
        public bool? IsTubeReceived { get; set; }
        public string Labperformed { get; set; }
        public bool? Testentered { get; set; }
        public long? Prtidu { get; set; }
        public bool? Issendout { get; set; }
        public string Comments { get; set; }

        public PatientReq Pre { get; set; }
        public ICollection<MicroBiologyResult> MicroBiologyResult { get; set; }
    }
}
