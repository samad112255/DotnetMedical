using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class RemotePrintingData
    {
        public long RemotePrintingDataId { get; set; }
        public string Id { get; set; }
        public string MainValue { get; set; }
        public string ExtraValue1 { get; set; }
        public string ExtraValue2 { get; set; }
        public string DisplayField1 { get; set; }
        public string DisplayField2 { get; set; }
        public int? Status { get; set; }
        public string Query { get; set; }
        public long? TransmittingJob { get; set; }
        public int? JobType { get; set; }

        public TransmittingJob TransmittingJobNavigation { get; set; }
    }
}
