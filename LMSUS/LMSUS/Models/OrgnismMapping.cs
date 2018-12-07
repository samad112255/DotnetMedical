using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class OrgnismMapping
    {
        public long MapId { get; set; }
        public long OrgId { get; set; }
        public string MapTestCode { get; set; }
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string Comments { get; set; }
    }
}
