using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class CytoParameters
    {
        public decimal CpId { get; set; }
        public string BCptcode { get; set; }
        public string BCunits { get; set; }
        public string BMcdcode { get; set; }
        public string BMunits { get; set; }
        public decimal? BPrice { get; set; }
        public string ICptcode { get; set; }
        public string ICunits { get; set; }
        public string IMcdcode { get; set; }
        public string IMunits { get; set; }
        public decimal? IPrice { get; set; }
    }
}
