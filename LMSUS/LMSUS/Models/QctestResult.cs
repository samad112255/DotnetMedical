using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class QctestResult
    {
        public long QctestResultId { get; set; }
        public long QctestId { get; set; }
        public long QcmainId { get; set; }
        public string LotNo { get; set; }
        public DateTime ResultDate { get; set; }
        public decimal? Result { get; set; }
        public string Unit { get; set; }
        public string ResultCharater { get; set; }

        public Qcmain Qcmain { get; set; }
        public Qctest Qctest { get; set; }
    }
}
