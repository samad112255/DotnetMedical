using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class GroupRights
    {
        public long GroupId { get; set; }
        public long? FormId { get; set; }
        public bool? Enable { get; set; }
        public long GroupRightsId { get; set; }

        public UserGroups Group { get; set; }
    }
}
