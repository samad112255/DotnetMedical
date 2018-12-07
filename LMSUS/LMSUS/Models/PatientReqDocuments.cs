using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqDocuments
    {
        public long PreDocId { get; set; }
        public long? PreId { get; set; }
        public byte[] ReqDocument { get; set; }
        public string DocumentComment { get; set; }
        public long? Createdby { get; set; }
        public DateTime? Createdtime { get; set; }
        public string FileName { get; set; }

        public PatientReq Pre { get; set; }
    }
}
