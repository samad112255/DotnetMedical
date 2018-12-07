using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class SalesMan
    {
        public long SalId { get; set; }
        public decimal? SalCode { get; set; }
        public string SalSsn { get; set; }
        public string SalLastName { get; set; }
        public string SalFirstName { get; set; }
        public string SalAddress { get; set; }
        public string SalPhone { get; set; }
        public string SalFax { get; set; }
        public string SalEmail { get; set; }
        public string SalRemark { get; set; }
        public string SalCell { get; set; }
        public long? ZipId { get; set; }
        public decimal? SalComm1 { get; set; }
        public decimal? SalComm2 { get; set; }
        public decimal? SalComm3 { get; set; }
    }
}
