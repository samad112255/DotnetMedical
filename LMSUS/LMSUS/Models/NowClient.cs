using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowClient
    {
        public NowClient()
        {
            NowClientmodule = new HashSet<NowClientmodule>();
            NowLabitemrequest = new HashSet<NowLabitemrequest>();
        }

        public long ClientId { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int IsDeleted { get; set; }
        public decimal? CompanyId { get; set; }
        public string Ssno { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MailAddress { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public long? CategoryId { get; set; }
        public string PasswordSalt { get; set; }
        public int? ClientActive { get; set; }
        public long? ClientStateId { get; set; }

        public NowCategory Category { get; set; }
        public ICollection<NowClientmodule> NowClientmodule { get; set; }
        public ICollection<NowLabitemrequest> NowLabitemrequest { get; set; }
    }
}
