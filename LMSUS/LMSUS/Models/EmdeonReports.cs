using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class EmdeonReports
    {
        public long ReportId { get; set; }
        public long ServerReportIdentity { get; set; }
        public string IdentityCode { get; set; }
        public string ReferenceNumber { get; set; }
        public string EmdeonRefernceNumber { get; set; }
        public byte[] FileContents { get; set; }
        public string ReportType { get; set; }
        public bool IsPicked { get; set; }
        public DateTime? ReportDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? PickedDate { get; set; }
        public bool? IsForClient { get; set; }
        public string FileDescription { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public bool? IsRead { get; set; }
    }
}
