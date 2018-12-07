using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class LabPro
    {
        public long LabProId { get; set; }
        public string AccessionNo { get; set; }
        public string SpecimenNo { get; set; }
        public string SpecimenDate { get; set; }
        public string SpecimenStatus { get; set; }
        public string IsolateNo { get; set; }
        public string TestGroupCode { get; set; }
        public string TestGroupDescription { get; set; }
        public string StatusDate { get; set; }
        public string NosocomialInfection { get; set; }
        public string OrganismCode { get; set; }
        public string OrganismDescription { get; set; }
        public string BioTypeNumber { get; set; }
        public string OrganismClass { get; set; }
        public string OrganismSet { get; set; }
        public string MicId { get; set; }
        public string DrugTestCode { get; set; }
        public string DrugTestDescription { get; set; }
        public string MicValue { get; set; }
        public string Sensitivity { get; set; }
    }
}
