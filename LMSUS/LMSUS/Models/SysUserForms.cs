using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class SysUserForms
    {
        public long FkUserId { get; set; }
        public decimal FkFormId { get; set; }
        public decimal PkId { get; set; }

        public SysForms FkForm { get; set; }
        public LmsUser FkUser { get; set; }
    }
}
