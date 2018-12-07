using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSUS.Models
{
    public class DoctorDropDownViewModel
    {
        public long DocId { get; set; }
        public decimal? DocCode { get; set; }
        public string DocLastName { get; set; }
        public string DocFirstName { get; set; }
    }
}
