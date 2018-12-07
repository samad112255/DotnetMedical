using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class TempPrice
    {
        public long Priceid { get; set; }
        public decimal? Price { get; set; }
        public decimal? TestCode { get; set; }
        public int? PrIndex { get; set; }
    }
}
