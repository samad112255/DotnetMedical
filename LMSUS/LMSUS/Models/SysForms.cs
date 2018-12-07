using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class SysForms
    {
        public SysForms()
        {
            SysUserForms = new HashSet<SysUserForms>();
        }

        public decimal PkId { get; set; }
        public string FormName { get; set; }
        public string Caption { get; set; }

        public ICollection<SysUserForms> SysUserForms { get; set; }
    }
}
