using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Site
    {
        public Site()
        {
            PatSchedule = new HashSet<PatSchedule>();
        }

        public long Sid { get; set; }
        public decimal? Scode { get; set; }
        public string Sname { get; set; }
        public string Saddress { get; set; }
        public long? ZipId { get; set; }
        public string Stnumber { get; set; }
        public string Sfnumber { get; set; }
        public string Scomments { get; set; }

        public ICollection<PatSchedule> PatSchedule { get; set; }
    }
}
