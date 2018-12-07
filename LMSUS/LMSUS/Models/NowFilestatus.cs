using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowFilestatus
    {
        public NowFilestatus()
        {
            NowFileuploadPatient = new HashSet<NowFileuploadPatient>();
        }

        public long FileStausId { get; set; }
        public string FileStatus { get; set; }

        public ICollection<NowFileuploadPatient> NowFileuploadPatient { get; set; }
    }
}
