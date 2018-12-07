using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class BDoctor
    {
        public BDoctor()
        {
            ClientInvoices = new HashSet<ClientInvoices>();
            ClientTranMaster = new HashSet<ClientTranMaster>();
            InsTranMaster = new HashSet<InsTranMaster>();
            InvoiceMaster = new HashSet<InvoiceMaster>();
        }

        public long DocId { get; set; }
        public string DocCode { get; set; }
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
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public decimal? SalId { get; set; }
        public string StName { get; set; }
        public string Nipnumber { get; set; }

        public ICollection<ClientInvoices> ClientInvoices { get; set; }
        public ICollection<ClientTranMaster> ClientTranMaster { get; set; }
        public ICollection<InsTranMaster> InsTranMaster { get; set; }
        public ICollection<InvoiceMaster> InvoiceMaster { get; set; }
    }
}
