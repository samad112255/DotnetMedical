using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Qcmain
    {
        public Qcmain()
        {
            Qctest = new HashSet<Qctest>();
            QctestResult = new HashSet<QctestResult>();
        }

        public long QcmainId { get; set; }
        public string LotNo { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string MachineCode { get; set; }
        public string ControlName { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Qctest> Qctest { get; set; }
        public ICollection<QctestResult> QctestResult { get; set; }
    }
}
