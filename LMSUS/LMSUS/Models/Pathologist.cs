using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Pathologist
    {
        public Pathologist()
        {
            PatientReq = new HashSet<PatientReq>();
        }

        public long PatId { get; set; }
        public string PatCode { get; set; }
        public string PatSsn { get; set; }
        public string PatLastName { get; set; }
        public string PatFirstName { get; set; }
        public string PatAddress { get; set; }
        public string PatPhone { get; set; }
        public string PatFax { get; set; }
        public string PatEmail { get; set; }
        public string LicenceNo { get; set; }
        public string UpinNo { get; set; }
        public string MedicaId { get; set; }
        public string MedicareId { get; set; }
        public string PatDescription { get; set; }
        public DateTime? PatStartDate { get; set; }
        public DateTime? PatEndDate { get; set; }
        public bool? IsDirector { get; set; }
        public long? ZipId { get; set; }
        public string CellNo { get; set; }
        public bool? HasEnd { get; set; }

        public ICollection<PatientReq> PatientReq { get; set; }
    }
}
