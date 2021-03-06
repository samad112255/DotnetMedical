﻿using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class TestRelatedDiag10
    {
        public int DtId { get; set; }
        public decimal? TestId { get; set; }
        public long? DiaId { get; set; }
        public decimal? Relevence { get; set; }
        public string TestType { get; set; }
        public string Type { get; set; }

        public Diagnosis10 Dia { get; set; }
    }
}
