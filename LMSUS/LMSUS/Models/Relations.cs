using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Relations
    {
        public Relations()
        {
            PatientReqAddnBillInfo = new HashSet<PatientReqAddnBillInfo>();
        }

        public long RelationId { get; set; }
        public string RelationDescription { get; set; }
        public string IsFavorite { get; set; }

        public ICollection<PatientReqAddnBillInfo> PatientReqAddnBillInfo { get; set; }
    }
}
