using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Aclresults
    {
        public long Aclid { get; set; }
        public DateTime? AccDate { get; set; }
        public string AccessionNumber { get; set; }
        public string TestCode { get; set; }
        public string Result1 { get; set; }
        public string Result2 { get; set; }
        public string Result { get; set; }
    }
}
