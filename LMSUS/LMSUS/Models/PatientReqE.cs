using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqE
    {
        public long PreIdE { get; set; }
        public long? PreAccNo { get; set; }
        public DateTime? PreAccDate { get; set; }
        public string PreReqNo { get; set; }
        public long PreDocId { get; set; }
        public long PaId { get; set; }
        public long? PatId { get; set; }
        public DateTime? PreDrawnDate { get; set; }
        public DateTime? PreRecDate { get; set; }
        public long? DirId { get; set; }
        public string PatComments { get; set; }
        public string WsComments { get; set; }
        public string RepComments { get; set; }
        public string PreSpType { get; set; }
        public long? InsId1 { get; set; }
        public long? InsId2 { get; set; }
        public string InsNo1 { get; set; }
        public string InsNo2 { get; set; }
        public string InsGroupNo { get; set; }
        public string BillTo { get; set; }
        public string Sst { get; set; }
        public string Lav { get; set; }
        public string Gry { get; set; }
        public string Blu { get; set; }
        public string Uri { get; set; }
        public string Swa { get; set; }
        public string Sto { get; set; }
        public string Red { get; set; }
        public string Grn { get; set; }
        public string Oth { get; set; }
        public DateTime? ReportDate { get; set; }
        public string SiteNo { get; set; }
        public string Printed { get; set; }
        public string ReportIntDate { get; set; }
        public string ReportLstDate { get; set; }
        public string Completed { get; set; }
        public string RelClinicalInfo { get; set; }
        public string Fasting { get; set; }
        public string Race { get; set; }
        public string Pregnant { get; set; }
        public string PreDocId1 { get; set; }
        public string PreDocId2 { get; set; }
        public string PreDocId3 { get; set; }
        public string DeletedTestsCodes { get; set; }
        public string PatientNotes { get; set; }
        public string SelfInsured { get; set; }
        public bool? AddMicro { get; set; }
        public bool? AddClinical { get; set; }
        public bool? AddBloodLead { get; set; }
        public bool? AddAfp { get; set; }
        public bool? AddCytology { get; set; }
        public bool? ViaHl7 { get; set; }
        public string RefLabComments { get; set; }
        public string IsSpecimenVerified { get; set; }
        public long? TempPreAccno { get; set; }
        public string DrAccno { get; set; }
        public bool? IsHl7 { get; set; }
        public long? InsId3 { get; set; }
        public string InsNo3 { get; set; }
        public bool? IsFinal { get; set; }
        public DateTime? Hl7sendDate { get; set; }
        public DateTime? DateSpecimenRecvd { get; set; }
        public bool? SndSpecimen { get; set; }
        public bool? IsPdf { get; set; }
        public DateTime? IsPdfDate { get; set; }
        public bool? Psc { get; set; }
        public string Hl7messageControlId { get; set; }
        
    }
}
