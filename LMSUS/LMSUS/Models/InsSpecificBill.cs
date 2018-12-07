using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsSpecificBill
    {
        public int IbId { get; set; }
        public decimal? TestId { get; set; }
        public string TestCode { get; set; }
        public decimal? InsId { get; set; }
        public bool? Bill { get; set; }
        public string CptCode1 { get; set; }
        public string Unit1 { get; set; }
        public decimal? Amount1 { get; set; }
        public string CptCode2 { get; set; }
        public string Unit2 { get; set; }
        public decimal? Amount2 { get; set; }
        public string CptCode3 { get; set; }
        public string Unit3 { get; set; }
        public decimal? Amount3 { get; set; }
        public string TypeOfServ { get; set; }
        public string PlaceOfServ { get; set; }
        public string TestType { get; set; }
        public string Type { get; set; }
    }
}
