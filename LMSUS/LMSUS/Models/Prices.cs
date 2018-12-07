using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Prices
    {
        public decimal PrId { get; set; }
        public decimal? TgrId { get; set; }
        public string TgrCode { get; set; }
        public decimal? PrIndex { get; set; }
        public decimal? TgrPrice { get; set; }
        public string TestType { get; set; }
        public string Type { get; set; }
    }
}
