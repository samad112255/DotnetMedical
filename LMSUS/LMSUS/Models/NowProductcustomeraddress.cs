using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowProductcustomeraddress
    {
        public long CustomerAddressId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public long Country { get; set; }
        public string City { get; set; }
        public long? StateId { get; set; }
        public string OtherState { get; set; }
        public bool AddressType { get; set; }
        public string Phone { get; set; }
        public decimal? PhoneExt { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }

        public NowCountry CountryNavigation { get; set; }
        public NowState State { get; set; }
    }
}
