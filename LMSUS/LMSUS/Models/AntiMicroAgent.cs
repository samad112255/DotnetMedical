using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class AntiMicroAgent
    {
        public AntiMicroAgent()
        {
            AmagrAntiAgent = new HashSet<AmagrAntiAgent>();
            MicroResultOrganism = new HashSet<MicroResultOrganism>();
        }

        public long AgId { get; set; }
        public long? AgCode { get; set; }
        public string AgName { get; set; }
        public string AgWorkSheet { get; set; }
        public string AgStr { get; set; }
        public string AgMin { get; set; }
        public string AgShortCode { get; set; }

        public ICollection<AmagrAntiAgent> AmagrAntiAgent { get; set; }
        public ICollection<MicroResultOrganism> MicroResultOrganism { get; set; }
    }
}
