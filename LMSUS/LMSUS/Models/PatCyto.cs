using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatCyto
    {
        public long PcId { get; set; }
        public long? PatId { get; set; }
        public long? CtId { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public long? BodyId { get; set; }
        public string BodyCode { get; set; }
        public string BodyName { get; set; }
        public byte[] CytoImage { get; set; }
        public string CytoType { get; set; }
        public string BatchNumber { get; set; }

        public BodyParts Body { get; set; }
        public CytologyTest Ct { get; set; }
        public PatientReq Pat { get; set; }
    }
}
