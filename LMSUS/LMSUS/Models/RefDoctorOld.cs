using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class RefDoctorOld
    {
        public decimal DocId { get; set; }
        public decimal? DocCode { get; set; }
        public string DocSsn { get; set; }
        public string DocLastName { get; set; }
        public string DocFirstName { get; set; }
        public string DocPhone { get; set; }
        public string DocMobileNo { get; set; }
        public string DocAddress { get; set; }
        public string DocFax { get; set; }
        public string DocSex { get; set; }
        public string DocEmail { get; set; }
        public string DocDescription { get; set; }
        public decimal? SalId { get; set; }
        public string LicenceNo { get; set; }
        public string UpinNo { get; set; }
        public string MedicaIdNo { get; set; }
        public string MedicareIdNo { get; set; }
        public bool? RemotePrinter { get; set; }
        public bool? CompRp { get; set; }
        public string RemPrinterNo { get; set; }
        public string ModemNo { get; set; }
        public string RouteNo { get; set; }
        public string IniRepSet { get; set; }
        public string SpOption { get; set; }
        public string SpecialTest { get; set; }
        public string AterNo { get; set; }
        public string BeeperNo { get; set; }
        public decimal? ZipId { get; set; }
    }
}
