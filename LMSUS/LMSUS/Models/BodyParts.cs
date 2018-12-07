using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class BodyParts
    {
        public BodyParts()
        {
            PatCyto = new HashSet<PatCyto>();
        }

        public long BodyId { get; set; }
        public string BodyCode { get; set; }
        public string BodyName { get; set; }
        public byte[] BodyImage { get; set; }
        public long? SpId { get; set; }

        public ICollection<PatCyto> PatCyto { get; set; }
    }
}
