using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class SuperProfileDetail
    {
        public long SpdId { get; set; }
        public long? SproId { get; set; }
        public decimal? TgproId { get; set; }
        public decimal? TgproCode { get; set; }
        public string TgproType { get; set; }

        public SuperProfile Spro { get; set; }
    }
}
