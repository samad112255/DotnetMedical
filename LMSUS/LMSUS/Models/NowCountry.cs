using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowCountry
    {
        public NowCountry()
        {
            NowProductcustomeraddress = new HashSet<NowProductcustomeraddress>();
        }

        public long CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public ICollection<NowProductcustomeraddress> NowProductcustomeraddress { get; set; }
    }
}
