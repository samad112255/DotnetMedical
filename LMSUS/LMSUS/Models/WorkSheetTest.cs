using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class WorkSheetTest
    {
        public long WtId { get; set; }
        public long? WsId { get; set; }
        public long? TestId { get; set; }
        public int SortOrder { get; set; }
        public decimal WsCode { get; set; }

        public ClinicalTest Test { get; set; }
        public WorkSheet Ws { get; set; }
    }
}
