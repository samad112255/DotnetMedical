using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Organism
    {
        public Organism()
        {
            MicroResultOrganism = new HashSet<MicroResultOrganism>();
        }

        public long OrgId { get; set; }
        public long? OrgCode { get; set; }
        public string OrgName { get; set; }
        public long? AmaGrId { get; set; }

        public AmaGroup AmaGr { get; set; }
        public ICollection<MicroResultOrganism> MicroResultOrganism { get; set; }
    }
}
