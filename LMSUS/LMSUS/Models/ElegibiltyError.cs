using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ElegibiltyError
    {
        public long ElgibilityId { get; set; }
        public long? PreId { get; set; }
        public string Accno { get; set; }
        public string Error { get; set; }
    }
}
