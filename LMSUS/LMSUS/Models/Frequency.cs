using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Frequency
    {
        public Frequency()
        {
            PatScheduleTest = new HashSet<PatScheduleTest>();
        }

        public long Fid { get; set; }
        public string Fcode { get; set; }
        public string Fdescription { get; set; }
        public string Ftype { get; set; }
        public decimal? Fnodays { get; set; }
        public bool? Fsun { get; set; }
        public bool? Fmon { get; set; }
        public bool? Ftues { get; set; }
        public bool? Fwed { get; set; }
        public bool? Fthur { get; set; }
        public bool? Ffri { get; set; }
        public bool? Fsat { get; set; }
        public string Ffrequency { get; set; }

        public ICollection<PatScheduleTest> PatScheduleTest { get; set; }
    }
}
