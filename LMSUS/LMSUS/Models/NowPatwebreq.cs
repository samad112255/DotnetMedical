using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowPatwebreq
    {
        public NowPatwebreq()
        {
            NowPatwebtest = new HashSet<NowPatwebtest>();
        }

        public long ReqId { get; set; }
        public long? CategoryId { get; set; }
        public DateTime? BatchDate { get; set; }
        public long? BatchNo { get; set; }
        public string PatientSsn { get; set; }
        public string PatientFmp { get; set; }
        public string PatientLastName { get; set; }
        public string PaientFirstName { get; set; }
        public string PatientMidInitial { get; set; }
        public DateTime? PatientDob { get; set; }
        public string AccessionNo { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string SpecimenSourceCode { get; set; }
        public string PatientDutyCode { get; set; }
        public long? FileTypeId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public NowPatwebreqbatch BatchNoNavigation { get; set; }
        public NowCategory Category { get; set; }
        public ICollection<NowPatwebtest> NowPatwebtest { get; set; }
    }
}
