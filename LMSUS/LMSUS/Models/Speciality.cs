using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Speciality
    {
        public long SpId { get; set; }
        public string SpecialtyCode { get; set; }
        public string SpecialtyName { get; set; }
        public string ReportName { get; set; }
    }
}
