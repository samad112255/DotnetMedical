using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Qctest
    {
        public Qctest()
        {
            QctestResult = new HashSet<QctestResult>();
        }

        public long QctestId { get; set; }
        public long QcmainId { get; set; }
        public string LotNo { get; set; }
        public long TestId { get; set; }
        public string MachineCode { get; set; }
        public decimal? StarndardHigh { get; set; }
        public decimal? StarndardLow { get; set; }
        public decimal? StandardMean { get; set; }
        public long TestCode { get; set; }
        public string TestShortName { get; set; }
        public string TestName { get; set; }
        public decimal? QcXAxisValue { get; set; }
        public decimal? QcYAxisValue { get; set; }
        public decimal? StandardSd { get; set; }
        public decimal? StandardCv { get; set; }
        public string StandardNormal { get; set; }

        public Qcmain Qcmain { get; set; }
        public ICollection<QctestResult> QctestResult { get; set; }
    }
}
