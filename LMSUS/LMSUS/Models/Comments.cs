using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Comments
    {
        public Comments()
        {
            ClinicalResultComm = new HashSet<ClinicalResultComm>();
        }

        public long ComId { get; set; }
        public long ComCode { get; set; }
        public string ComDescription { get; set; }
        public long CtId { get; set; }
        public string RichTextFormat { get; set; }

        public CommentType Ct { get; set; }
        public ICollection<ClinicalResultComm> ClinicalResultComm { get; set; }
    }
}
