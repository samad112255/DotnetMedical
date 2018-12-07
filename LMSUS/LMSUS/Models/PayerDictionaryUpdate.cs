using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PayerDictionaryUpdate
    {
        public long InsuranceUpdateId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string TypeOfUpdate { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
    }
}
