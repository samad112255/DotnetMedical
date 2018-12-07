using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class TestBilling
    {
        public decimal Pkid { get; set; }
        public decimal? TestId { get; set; }
        public string TestType { get; set; }
        public string Type { get; set; }
        public bool? BillIns { get; set; }
        public bool? BillPpatient { get; set; }
        public bool? BillAccount { get; set; }
        public bool? Discountable { get; set; }
        public string CptCode { get; set; }
        public int? CptUnit { get; set; }
        public string McdCode { get; set; }
        public int? McdUnit { get; set; }
        public string CptCombCode { get; set; }
        public string CptSubstCode { get; set; }
        public string McdCombCode { get; set; }
        public string McdSubstCode { get; set; }
        public string TosMcr { get; set; }
        public string TosMcd { get; set; }
        public string TosUcf { get; set; }
        public string PosMcr { get; set; }
        public string PosMcd { get; set; }
        public string PosUcf { get; set; }
        public decimal? TestCost { get; set; }
        public string CostType { get; set; }
    }
}
