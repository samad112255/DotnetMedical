using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ProfileDetail
    {
        public decimal ProDId { get; set; }
        public long? ProId { get; set; }
        public decimal? TestGrId { get; set; }
        public decimal? TestGrCode { get; set; }
        public string TestGrType { get; set; }

        public Profile Pro { get; set; }
    }
}
