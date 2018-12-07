using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class MicroCodes
    {
        public long MicroId { get; set; }
        public string MicroCode { get; set; }
        public string MicroDescription { get; set; }
        public string CptCode { get; set; }
        public string IcdCode { get; set; }
        public string MicroFollowUp { get; set; }
        public long? CatId { get; set; }
        public string Diagnosis { get; set; }
        public long? InfoId { get; set; }
    }
}
