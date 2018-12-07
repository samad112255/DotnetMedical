using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Patient
    {
        public Patient()
        {
            PatientReq = new HashSet<PatientReq>();
        }

        public long PaId { get; set; }
        public string PaSsn { get; set; }
        public string PaLastName { get; set; }
        public string PaFirstName { get; set; }
        public int? Age { get; set; }
        public string PaAddress { get; set; }
        public string PaChartNo { get; set; }
        public string PaPhone { get; set; }
        public string PaFax { get; set; }
        public string PaSex { get; set; }
        public string PaEmail { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? ZipId { get; set; }
        public string Status { get; set; }
        public long? InsId { get; set; }
        public string InsNo { get; set; }
        public string GroupNumber { get; set; }

        public ICollection<PatientReq> PatientReq { get; set; }
    }
}
