using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class LmsauditTrial
    {
        public LmsauditTrial()
        {
            LmsauditOther = new HashSet<LmsauditOther>();
        }

        public long LmsauditTrialId { get; set; }
        public long? LmsUserId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Ip { get; set; }
        public DateTime DateNtime { get; set; }
        public long AuditActionId { get; set; }
        public string AuditAction { get; set; }
        public string ActionDescription { get; set; }
        public string FormDll { get; set; }
        public string FormName { get; set; }
        public byte[] OldData { get; set; }
        public string FormTitle { get; set; }
        public string FormBlname { get; set; }
        public string FormExtraValue1 { get; set; }
        public string AccessionNo { get; set; }

        public AuditAction AuditActionNavigation { get; set; }
        public ICollection<LmsauditOther> LmsauditOther { get; set; }
    }
}
