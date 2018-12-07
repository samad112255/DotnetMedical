using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class LmsauditOther
    {
        public long LmsauditOtherId { get; set; }
        public long LmsauditId { get; set; }
        public byte[] LmsnewVal { get; set; }

        public LmsauditTrial Lmsaudit { get; set; }
    }
}
