using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class UserGroups
    {
        public UserGroups()
        {
            GroupRights = new HashSet<GroupRights>();
            LmsUser = new HashSet<LmsUser>();
        }

        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public int? GroupSecurityLevel { get; set; }

        public ICollection<GroupRights> GroupRights { get; set; }
        public ICollection<LmsUser> LmsUser { get; set; }
    }
}
