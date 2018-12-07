using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PracCat
    {
        public long Pkid { get; set; }
        public long? PracId { get; set; }
        public long? CatId { get; set; }
    }
}
