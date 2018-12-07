using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PracDoc
    {
        public long Pkid { get; set; }
        public long? DocId { get; set; }
        public long? PracId { get; set; }
    }
}
