using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ClinicalTestRefLabMapping
    {
        public long TestRefLabId { get; set; }
        public long? TestId { get; set; }
        public long? InsId { get; set; }
        public long? ClId { get; set; }
        public bool? IsDefault { get; set; }

        public RefClinicLab Cl { get; set; }
        public Insurance Ins { get; set; }
        public ClinicalTest Test { get; set; }
    }
}
