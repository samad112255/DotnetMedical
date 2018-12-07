using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class RefDocSpTest
    {
        public long RefDocSpTestId { get; set; }
        public long? DocId { get; set; }
        public string Type { get; set; }
        public string TgspType { get; set; }
        public long? TgspId { get; set; }
        public string TgspCode { get; set; }
        public string TgspName { get; set; }
        public string Amount { get; set; }
        public long? InsId { get; set; }
    }
}
