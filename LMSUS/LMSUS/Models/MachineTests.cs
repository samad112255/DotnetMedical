using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class MachineTests
    {
        public long MachineTestId { get; set; }
        public string MachineTest { get; set; }
        public decimal? LabTest { get; set; }
        public string MachineCode { get; set; }
        public string Comments { get; set; }
        public long? TestId { get; set; }
        public string TestName { get; set; }
        public string Op { get; set; }
        public string Cvalue { get; set; }
        public string TrueResult { get; set; }
        public string FalseResult { get; set; }
        public string Op1 { get; set; }
        public string Cvalue1 { get; set; }
        public int? DPoint { get; set; }

        public ClinicalTest Test { get; set; }
    }
}
