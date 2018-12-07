using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class LmsUser
    {
        public LmsUser()
        {
            SysUserForms = new HashSet<SysUserForms>();
        }

        public long LmsUserId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Initials { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public long? GroupId { get; set; }
        public byte? IsLoginFirstTime { get; set; }

        public UserGroups Group { get; set; }
        public ICollection<SysUserForms> SysUserForms { get; set; }
    }
}
