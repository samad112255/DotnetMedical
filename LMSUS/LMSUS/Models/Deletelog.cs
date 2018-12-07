using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Deletelog
    {
        public long Id { get; set; }
        public string Preaccno { get; set; }
        public string Preid { get; set; }
        public string Computername { get; set; }
        public string Ip { get; set; }
        public string Deletedby { get; set; }
        public DateTime? Date { get; set; }
        public string Prtid { get; set; }
    }
}
