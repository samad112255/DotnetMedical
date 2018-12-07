using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowFiletype
    {
        public NowFiletype()
        {
            NowFileuploadPatient = new HashSet<NowFileuploadPatient>();
        }

        public long FileTypeId { get; set; }
        public string FileType { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowFileuploadPatient> NowFileuploadPatient { get; set; }
    }
}
