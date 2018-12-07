using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InfoSheet
    {
        public long InfoId { get; set; }
        public string InfoCode { get; set; }
        public string InfoDesc { get; set; }
        public string InfoMemo { get; set; }
    }
}
