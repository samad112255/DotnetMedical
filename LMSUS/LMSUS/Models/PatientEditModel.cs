using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSUS.Models
{
    public class PatientEditModel
    {
        public long PaIdE { get; set; }
        public string PaSsn { get; set; }
        public string PaLastName { get; set; }
        public string PaFirstName { get; set; }
        public int? Age { get; set; }
        public string PaAddress { get; set; }
        public string PaChartNo { get; set; }
        public string PaPhone { get; set; }
        public string PaFax { get; set; }
        public string PaSex { get; set; }
        public string PaEmail { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? ZipId { get; set; }
        public string Status { get; set; }
        public long? InsId { get; set; }
        public string InsNo { get; set; }
        public string GroupNumber { get; set; }


        public long PreIdE { get; set; }
        public long? PreAccNo { get; set; }
        public DateTime? PreAccDate { get; set; }
        public string PreReqNo { get; set; }
        public long PreDocId { get; set; }
        public long PaId { get; set; }
        public long? PatId { get; set; }
        

        
        public string InsCode { get; set; }
        public string InsName { get; set; }
        public string InsAddress { get; set; }
        public string InsPhone { get; set; }
        public string InsFax { get; set; }
        public string InsEmail { get; set; }
        public string InsContactPerson { get; set; }
       
        
      

        public long DocId { get; set; }
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
      
      
       
       
       

    }
}
