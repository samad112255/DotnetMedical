using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class DeletedTest
    {
        public long Id { get; set; }
        public long? PreId { get; set; }
        public long? TestId { get; set; }
        public string TestCode { get; set; }
        public long? PrtId { get; set; }
    }
}
