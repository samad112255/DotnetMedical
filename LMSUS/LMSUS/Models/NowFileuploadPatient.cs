using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowFileuploadPatient
    {
        public long FileUploadId { get; set; }
        public string FileName { get; set; }
        public string FileSystemName { get; set; }
        public long UploadedBy { get; set; }
        public long Status { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? ProcessedBy { get; set; }
        public DateTime? ProcessTime { get; set; }
        public long FileTypeId { get; set; }
        public string FilePath { get; set; }
        public decimal? FileSize { get; set; }
        public string FileDownloadPath { get; set; }
        public int? FileIsDownloaded { get; set; }
        public long? FileDownloadedBy { get; set; }
        public DateTime? FileDownloadTime { get; set; }
        public decimal? FileDownloadSize { get; set; }
        public long? CategoryId { get; set; }
        public string FileDownloadVirtualPath { get; set; }

        public NowFiletype FileType { get; set; }
        public NowFilestatus StatusNavigation { get; set; }
    }
}
