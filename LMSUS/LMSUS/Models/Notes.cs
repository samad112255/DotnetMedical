using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Notes
    {
        public decimal NotId { get; set; }
        public string NotCode { get; set; }
        public string NotDescription { get; set; }
        public string NotFollow { get; set; }
        public decimal? CatId { get; set; }
    }
}
