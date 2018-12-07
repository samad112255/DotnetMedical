using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowLabitemrequeststatus
    {
        public NowLabitemrequeststatus()
        {
            NowLabitemrequest = new HashSet<NowLabitemrequest>();
        }

        public long LabItemRequestStatusId { get; set; }
        public string LabItemRequestDesc { get; set; }

        public ICollection<NowLabitemrequest> NowLabitemrequest { get; set; }
    }
}
