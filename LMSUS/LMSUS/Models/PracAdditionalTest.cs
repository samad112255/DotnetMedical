using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PracAdditionalTest
    {
        public long PracAddTestDetailsId { get; set; }
        public long Pkid { get; set; }
        public string AdditionalTestDetails { get; set; }
        public int? Type { get; set; }
    }
}
