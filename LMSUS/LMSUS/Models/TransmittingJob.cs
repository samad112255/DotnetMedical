using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class TransmittingJob
    {
        public TransmittingJob()
        {
            RemotePrintingData = new HashSet<RemotePrintingData>();
        }

        public long TransmittingJob1 { get; set; }
        public string Query { get; set; }
        public int? JobType { get; set; }
        public int? JobStatus { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? StartingDate { get; set; }
        public string Message { get; set; }
        public string ReportBl { get; set; }
        public string ReportDcoument { get; set; }
        public string ReportDll { get; set; }

        public ICollection<RemotePrintingData> RemotePrintingData { get; set; }
    }
}
