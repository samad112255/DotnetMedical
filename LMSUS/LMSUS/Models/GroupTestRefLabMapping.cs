using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class GroupTestRefLabMapping
    {
        public long GroupRefLabId { get; set; }
        public long? GrId { get; set; }
        public long? InsId { get; set; }
        public long? ClId { get; set; }
        public bool? IsDefault { get; set; }
    }
}
