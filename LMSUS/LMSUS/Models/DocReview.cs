using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class DocReview
    {
        public long Rid { get; set; }
        public long? PcId { get; set; }
        public string ClinicalDisgnosis { get; set; }
        public string Psa { get; set; }
        public string Dre { get; set; }
        public string Site { get; set; }
        public string Gleason { get; set; }
        public string Pct { get; set; }
        public string History { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime? PreDate { get; set; }
        public string ReviewedBy { get; set; }
        public DateTime? FinalDate { get; set; }
        public string NotesDescription { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] ScanedImage { get; set; }
        public bool? OverWrite { get; set; }
        public string Status { get; set; }
        public string Preminilary { get; set; }
        public string FollowUp { get; set; }
        public bool? Approved { get; set; }
        public long? CatId { get; set; }
        public string Age { get; set; }
        public long? GrId { get; set; }
    }
}
