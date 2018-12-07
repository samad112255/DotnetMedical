using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class GroupTestDetail
    {
        public long GroupTestId { get; set; }
        public long? GdTestId { get; set; }
        public string GdTestCode { get; set; }
        public string GdTestName { get; set; }
        public string GdType { get; set; }
        public string GdStype { get; set; }
        public long? GdPreId { get; set; }
        public long? GdPrtId { get; set; }
        public string GdPreAccno { get; set; }
        public string IsDeleted { get; set; }
    }
}
