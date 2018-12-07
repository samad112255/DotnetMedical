using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class CentaurResultsCopy
    {
        public long PkId { get; set; }
        public string AccNo { get; set; }
        public string TestNo { get; set; }
        public string Results { get; set; }
        public string Unit { get; set; }
        public DateTime? Tdate { get; set; }
        public int? Orders { get; set; }
    }
}
