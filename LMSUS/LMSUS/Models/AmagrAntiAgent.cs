using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class AmagrAntiAgent
    {
        public long AmaGrDetailId { get; set; }
        public long? AmaGrId { get; set; }
        public long? AgId { get; set; }

        public AntiMicroAgent Ag { get; set; }
        public AmaGroup AmaGr { get; set; }
    }
}
