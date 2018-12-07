using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Specimen
    {
        public decimal SpId { get; set; }
        public string SpCode { get; set; }
        public string SpName { get; set; }
        public string SpDescription { get; set; }
        public decimal? SpTId { get; set; }
    }
}
