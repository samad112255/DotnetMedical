using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class GrossResults
    {
        public long GrId { get; set; }
        public long? PcId { get; set; }
        public string Bnumber { get; set; }
        public string Total { get; set; }
        public bool? NoGrossing { get; set; }
        public string Shape { get; set; }
        public string Measure { get; set; }
        public string Units { get; set; }
        public string Cassetes { get; set; }
        public string Pieces { get; set; }
        public string SpecType { get; set; }
        public string Fixative { get; set; }
        public bool? MultiplePieces { get; set; }
        public string Color { get; set; }
        public string BiopsyComments { get; set; }
        public string IgG { get; set; }
        public string IgM { get; set; }
        public string IgA { get; set; }
        public string Fibrinogen { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C1g { get; set; }
        public string Propardin { get; set; }
        public string ImmuneComments { get; set; }
        public string CytoType { get; set; }
    }
}
