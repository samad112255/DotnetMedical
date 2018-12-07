using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class MicroResultIsolate
    {
        public MicroResultIsolate()
        {
            MicroResultOrganism = new HashSet<MicroResultOrganism>();
        }

        public long MriId { get; set; }
        public long MbrId { get; set; }
        public string Isolate { get; set; }
        public string Comments { get; set; }

        public MicroBiologyResult Mbr { get; set; }
        public ICollection<MicroResultOrganism> MicroResultOrganism { get; set; }
    }
}
