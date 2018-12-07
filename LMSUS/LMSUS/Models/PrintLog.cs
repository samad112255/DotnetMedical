using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PrintLog
    {
        public decimal PkId { get; set; }
        public DateTime? PrintTime { get; set; }
        public string AccNo { get; set; }
        public string PrintJobId { get; set; }
        public string PaFirstName { get; set; }
        public string PaLastName { get; set; }
        public long? DocId { get; set; }
        public decimal? DocCode { get; set; }
        public string DocFirstName { get; set; }
        public string DocLastName { get; set; }
        public string DocPhone { get; set; }
        public string DocName { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string PrintStatus { get; set; }
        public DateTime? AutoPrintCreatedDate { get; set; }
        public bool? IsAutoPrint { get; set; }
    }
}
