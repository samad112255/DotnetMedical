using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatSchedule
    {
        public PatSchedule()
        {
            PatScheduleTest = new HashSet<PatScheduleTest>();
        }

        public long Psid { get; set; }
        public string PsPatId { get; set; }
        public string PsPatChartNo { get; set; }
        public string PsPatLastName { get; set; }
        public string PsPatFirstName { get; set; }
        public long? Sid { get; set; }
        public DateTime? PsPatDob { get; set; }
        public string PsPatSex { get; set; }
        public string PsWardRoom { get; set; }
        public string PsRoom { get; set; }
        public string PsPatAddress { get; set; }
        public long? PsZipId { get; set; }
        public string PsPatTel { get; set; }
        public string PsPatFax { get; set; }
        public long? PsPatDocId { get; set; }
        public long? PsPatInsId1 { get; set; }
        public string PsPatInsNo1 { get; set; }
        public long? PsPatInsId2 { get; set; }
        public string PsPatInsNo2 { get; set; }
        public string PsInsGroupNo { get; set; }
        public string PsDia1 { get; set; }
        public string PsDia2 { get; set; }
        public string PsDia3 { get; set; }
        public string PsDia4 { get; set; }
        public string PsDia5 { get; set; }
        public string PsStatus { get; set; }
        public DateTime? PsDate { get; set; }
        public string PsRemarks { get; set; }
        public bool? PsIsActive { get; set; }

        public Site S { get; set; }
        public ICollection<PatScheduleTest> PatScheduleTest { get; set; }
    }
}
