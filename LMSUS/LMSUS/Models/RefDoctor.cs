using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class RefDoctor
    {
        public RefDoctor()
        {
            PatientReq = new HashSet<PatientReq>();
            RefDoctorAdditionalTest = new HashSet<RefDoctorAdditionalTest>();
        }

        public long DocId { get; set; }
        public long? DocCode { get; set; }
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
        public long? SalId { get; set; }
        public long? Sal2Id { get; set; }
        public long? Sal3Id { get; set; }
        public decimal? SalComm { get; set; }
        public decimal? Sal2Comm { get; set; }
        public decimal? Sal3Comm { get; set; }
        public DateTime? SalAcDate { get; set; }
        public DateTime? Sal2AcDate { get; set; }
        public DateTime? Sal3AcDate { get; set; }
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
        public long? ZipId { get; set; }
        public string Nipnumber { get; set; }
        public bool? IncludeInSummaryRep { get; set; }
        public string RemotePrinter1 { get; set; }
        public int? ReportCopies { get; set; }
        public bool? CompRepOnly { get; set; }
        public bool? IncludeAbnormalResults { get; set; }
        public string Ipaddress { get; set; }
        public bool? Includeadditionaltest { get; set; }
        public bool? IsSendPdf { get; set; }
        public string UserPassword { get; set; }
        public string Status { get; set; }
        public DateTime? LastAccessed { get; set; }
        public bool? Exclude { get; set; }
        public string OtherDocCode { get; set; }
        public string Comments { get; set; }
        public bool? IsMicroperform { get; set; }
        public bool? Autofax { get; set; }
        public string Hl7ResultPath { get; set; }
        public string Hl7OrderPath { get; set; }
        public string InterFaceName { get; set; }
        public string DoctorStatus { get; set; }
        public bool? AutoPrint { get; set; }
        public bool? OnlyMicroTest { get; set; }
        public bool? Isorder { get; set; }
        public bool? LastModified { get; set; }
        public bool? IsBydoccode { get; set; }

        public ICollection<PatientReq> PatientReq { get; set; }
        public ICollection<RefDoctorAdditionalTest> RefDoctorAdditionalTest { get; set; }
    }
}
