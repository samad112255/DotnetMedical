using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatScheduleTest
    {
        public long PstId { get; set; }
        public long? PsId { get; set; }
        public long? Fid { get; set; }
        public string Fcode { get; set; }
        public DateTime? PstStartDate { get; set; }
        public DateTime? PstEndDate { get; set; }
        public string PstStatus { get; set; }
        public DateTime? PstLastSceduled { get; set; }
        public decimal? TestCode { get; set; }
        public string TestName { get; set; }
        public string TestTube { get; set; }
        public bool? IsActive { get; set; }

        public Frequency F { get; set; }
        public PatSchedule Ps { get; set; }
    }
}
