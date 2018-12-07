using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class MicroResultOrganism
    {
        public long MroId { get; set; }
        public long MriId { get; set; }
        public long? OrgId { get; set; }
        public long? AgId { get; set; }
        public string Sensitivity { get; set; }
        public string ColCount { get; set; }
        public string ColCode { get; set; }
        public string MicValue { get; set; }

        public AntiMicroAgent Ag { get; set; }
        public MicroResultIsolate Mri { get; set; }
        public Organism Org { get; set; }
    }
}
