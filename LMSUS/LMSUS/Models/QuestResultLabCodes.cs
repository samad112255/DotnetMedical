using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class QuestResultLabCodes
    {
        public long ResultTestId { get; set; }
        public string OrderTestCode { get; set; }
        public string OrderTestName { get; set; }
        public string ResultCode { get; set; }
        public string ResultName { get; set; }
        public string Loinc { get; set; }
    }
}
