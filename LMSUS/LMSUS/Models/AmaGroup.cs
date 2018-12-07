using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class AmaGroup
    {
        public AmaGroup()
        {
            AmagrAntiAgent = new HashSet<AmagrAntiAgent>();
            Organism = new HashSet<Organism>();
        }

        public long AmaGrId { get; set; }
        public long? AmaGrCode { get; set; }
        public string AmaGrName { get; set; }

        public ICollection<AmagrAntiAgent> AmagrAntiAgent { get; set; }
        public ICollection<Organism> Organism { get; set; }
    }
}
