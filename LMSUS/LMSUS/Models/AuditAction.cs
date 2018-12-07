using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class AuditAction
    {
        public AuditAction()
        {
            LmsauditTrial = new HashSet<LmsauditTrial>();
        }

        public long AuditActionId { get; set; }
        public string AuditActionDesc { get; set; }

        public ICollection<LmsauditTrial> LmsauditTrial { get; set; }
    }
}
