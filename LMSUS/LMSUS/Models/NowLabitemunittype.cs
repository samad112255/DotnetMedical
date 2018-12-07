using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitemunittype
    {
        public NowLabitemunittype()
        {
            NowLabitem = new HashSet<NowLabitem>();
        }

        public long LabItemUnitId { get; set; }
        public string LabItemUnitName { get; set; }

        public ICollection<NowLabitem> NowLabitem { get; set; }
    }
}
