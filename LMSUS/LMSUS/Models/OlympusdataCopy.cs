using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class OlympusdataCopy
    {
        public decimal Tid { get; set; }
        public decimal? AccNo { get; set; }
        public string TestNo { get; set; }
        public string TestResult { get; set; }
        public string TestValue { get; set; }
        public bool? IsTransferred { get; set; }
        public DateTime? Tdate { get; set; }
        public string Units { get; set; }
        public string HasError { get; set; }
        public int? Orders { get; set; }
    }
}
