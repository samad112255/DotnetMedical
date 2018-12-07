using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class RefDocSpIns
    {
        public long RefDocSpInsId { get; set; }
        public long? DocId { get; set; }
        public long? InsId { get; set; }
        public long? TestId { get; set; }
    }
}
