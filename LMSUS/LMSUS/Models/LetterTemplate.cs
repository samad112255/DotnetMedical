using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class LetterTemplate
    {
        public long LetterTemplateId { get; set; }
        public string LetterSubject { get; set; }
        public string LetterDescription { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsLocked { get; set; }
        public long? LockedBy { get; set; }
        public string LetterDescriptionRtf { get; set; }
    }
}
