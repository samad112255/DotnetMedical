using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ShielCompendiumT
    {
        public int OrderId { get; set; }
        public string OrderTestCode { get; set; }
        public string OrderTestName { get; set; }
        public string ResultTestCode { get; set; }
        public string ResultTestName { get; set; }
    }
}
