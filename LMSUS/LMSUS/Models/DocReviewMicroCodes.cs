using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class DocReviewMicroCodes
    {
        public long Rmid { get; set; }
        public long? Rid { get; set; }
        public string MicroCode { get; set; }
        public string Cptcode { get; set; }
        public string IcdCode { get; set; }
        public string Diagnosis { get; set; }
        public string MicroDescription { get; set; }
    }
}
