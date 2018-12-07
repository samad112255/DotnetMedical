using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Cobase411results
    {
        public long Id { get; set; }
        public string Ordercode { get; set; }
        public string TestNo { get; set; }
        public string Result { get; set; }
        public string Unit { get; set; }
        public DateTime? ResultDate { get; set; }
        public string PreDilutionType { get; set; }
    }
}
