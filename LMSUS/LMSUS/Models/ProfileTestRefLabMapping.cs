using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ProfileTestRefLabMapping
    {
        public long ProfileRefLabId { get; set; }
        public long? ProId { get; set; }
        public long? InsId { get; set; }
        public long? ClId { get; set; }
        public bool? IsDefault { get; set; }
    }
}
