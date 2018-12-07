using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class GroupDetail
    {
        public long GrDId { get; set; }
        public long GrId { get; set; }
        public long TestId { get; set; }

        public GroupTest Gr { get; set; }
        public ClinicalTest Test { get; set; }
    }
}
