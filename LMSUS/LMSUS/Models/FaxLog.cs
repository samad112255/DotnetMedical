using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class FaxLog
    {
        public decimal PkId { get; set; }
        public DateTime FaxTime { get; set; }
        public string AccNo { get; set; }
        public string PaFirstName { get; set; }
        public string PaLastName { get; set; }
        public long? DocId { get; set; }
        public decimal? DocCode { get; set; }
        public string DocFirstName { get; set; }
        public string DocLastName { get; set; }
        public string DocPhone { get; set; }
        public string DocName { get; set; }
        public string FaxNumber { get; set; }
        public string FaxJobId { get; set; }
        public string FileName { get; set; }
        public int? FaxPages { get; set; }
        public int? FaxSize { get; set; }
        public string FaxStatus { get; set; }
        public string Sender { get; set; }
        public bool? IsAutoFax { get; set; }
        public DateTime? AutoFaxCreatedDate { get; set; }
    }
}
