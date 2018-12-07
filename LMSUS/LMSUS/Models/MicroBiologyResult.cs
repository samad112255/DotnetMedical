using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class MicroBiologyResult
    {
        public MicroBiologyResult()
        {
            MicroResultIsolate = new HashSet<MicroResultIsolate>();
        }

        public long MbrId { get; set; }
        public long? AccNo { get; set; }
        public long? PrtId { get; set; }
        public string TestCode { get; set; }
        public bool? OneOrganism { get; set; }
        public bool? OneColCount { get; set; }
        public bool? OneResult { get; set; }
        public bool? TwoOrganism { get; set; }
        public bool? TwoColCount { get; set; }
        public bool? TwoResult { get; set; }
        public bool? ThreeOrganism { get; set; }
        public bool? ThreeColCount { get; set; }
        public bool? ThreeResult { get; set; }
        public bool? FourOrganism { get; set; }
        public bool? FourColCount { get; set; }
        public bool? FourResult { get; set; }
        public bool? FiveOrganism { get; set; }
        public bool? FiveColCount { get; set; }
        public bool? FiveResult { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public DateTime? ReportDate { get; set; }

        public PatientReqTest Prt { get; set; }
        public ICollection<MicroResultIsolate> MicroResultIsolate { get; set; }
    }
}
