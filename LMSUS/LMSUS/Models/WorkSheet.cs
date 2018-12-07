using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class WorkSheet
    {
        public WorkSheet()
        {
            WorkSheetTest = new HashSet<WorkSheetTest>();
        }

        public long WsId { get; set; }
        public decimal? WsCode { get; set; }
        public string WsName { get; set; }
        public string WsDescription { get; set; }

        public ICollection<WorkSheetTest> WorkSheetTest { get; set; }
    }
}
