using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Vitek
    {
        public long VitekId { get; set; }
        public string AccessionNumber { get; set; }
        public string ExamId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        public string Status { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string IsolateCode { get; set; }
        public string IsolateDescription { get; set; }
        public string OrganismCode { get; set; }
        public string OrganismName { get; set; }
        public string ColonyCountCode { get; set; }
        public string ColonyCountDesc { get; set; }
        public string AntimicrobialCodeA1 { get; set; }
        public string AntimicrobialDescriptionA2 { get; set; }
        public string MicA3 { get; set; }
        public string ResultA4 { get; set; }
        public bool? Verified { get; set; }
    }
}
