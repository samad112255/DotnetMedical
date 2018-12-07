using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSUS.Models
{
    public class GridData
    {
        public long PaIdE { get; set; }
        public long? PreAccNo { get; set; }
        public string PreReqNo { get; set; }
        public string PaSsn { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PaLastName { get; set; }
        public string PaFirstName { get; set; } 
        public decimal? DocCode { get; set; }
        public string DocFirstName { get; set; }
        public string DocLastName { get; set; }
        public string InsCode { get; set; }
        public DateTime? PreAccDate { get; set; }
        public DateTime? PreDrawnDate { get; set; }
    }
}
