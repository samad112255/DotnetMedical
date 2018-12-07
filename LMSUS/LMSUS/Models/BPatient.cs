using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class BPatient
    {
        public BPatient()
        {
            InvoiceMaster = new HashSet<InvoiceMaster>();
        }

        public long PaId { get; set; }
        public string PaSsn { get; set; }
        public string PaLastName { get; set; }
        public string PaFirstName { get; set; }
        public string PaAddress { get; set; }
        public string PaChartNo { get; set; }
        public string PaPhone { get; set; }
        public string PaFax { get; set; }
        public string PaSex { get; set; }
        public string PaEmail { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string StName { get; set; }

        public ICollection<InvoiceMaster> InvoiceMaster { get; set; }
    }
}
