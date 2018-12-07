using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class MicrobialMapping
    {
        public long MapId { get; set; }
        public decimal? AgId { get; set; }
        public string MapTestCode { get; set; }
        public string AgCode { get; set; }
        public string AgName { get; set; }
        public string Comments { get; set; }
    }
}
