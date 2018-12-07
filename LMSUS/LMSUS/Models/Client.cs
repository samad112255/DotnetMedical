using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Client
    {
        public long ClientId { get; set; }
        public long? ClientCode { get; set; }
        public string ClientLastName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientPhone { get; set; }
        public string ClientFax { get; set; }
        public string ClientEmail { get; set; }
        public string ClientWeb { get; set; }
        public string ClientContactPerson { get; set; }
        public byte[] ClientLogo { get; set; }
        public string ClientDescription { get; set; }
        public string ZipId { get; set; }
    }
}
