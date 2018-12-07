using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class SuperProfileTestRefLabMapping
    {
        public long SuperProfileRefLabId { get; set; }
        public long? SproId { get; set; }
        public long? InsId { get; set; }
        public long? ClId { get; set; }
        public bool? IsDefault { get; set; }
    }
}
