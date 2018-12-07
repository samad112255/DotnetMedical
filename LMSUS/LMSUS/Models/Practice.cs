using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Practice
    {
        public long Pkid { get; set; }
        public string Code { get; set; }
        public string Pname { get; set; }
        public string PnameOnReport { get; set; }
        public DateTime? EnterDate { get; set; }
        public bool? PatLetter { get; set; }
        public string PatLetterType { get; set; }
        public bool? PatInfoSheet { get; set; }
        public bool? RefDrLetter { get; set; }
        public decimal? NoOfCopies { get; set; }
        public bool? IsCall { get; set; }
        public bool? IsFax { get; set; }
        public bool? IsConsultation { get; set; }
        public bool? IsRush { get; set; }
        public bool? IsCheckMargins { get; set; }
        public bool? IsBiopsyBook { get; set; }
        public bool? IsSuppressFollowup { get; set; }
        public bool? IsChartNumber { get; set; }
        public bool? IsLabels { get; set; }
        public bool? IsEducationPamphlets { get; set; }
        public bool? IsResearchServices { get; set; }
        public bool? IsPracticeProfile { get; set; }
        public bool? IsIcdonReport { get; set; }
        public bool? IsWantSlides { get; set; }
        public bool? IsShowDiagram { get; set; }
        public bool? IsSendToRefDoctor { get; set; }
        public bool? IsSumPreviousTests { get; set; }
        public bool? IsSendPhoto { get; set; }
        public bool? IsPhoto { get; set; }
        public bool? IsExtraLabels { get; set; }
        public bool? IsPtSummLabels { get; set; }
        public bool? IsOverrideDiag { get; set; }
        public bool? IsColors { get; set; }
        public bool? IsForceRefDoctor { get; set; }
        public bool? IsSummaryReport { get; set; }
        public string Pdeclaimer { get; set; }
        public string PinstructionsforReviewingPathologist { get; set; }
        public string Paddress { get; set; }
        public string OtherPractice { get; set; }
        public long? ZipId { get; set; }
        public string Ppassword { get; set; }
        public bool? IncludeAddTest { get; set; }
        public string PracPhone { get; set; }
        public string PracFax { get; set; }
        public string PracCell { get; set; }
        public string PracStatus { get; set; }
        public bool? IsNotInclude { get; set; }
        public bool? AutoFax { get; set; }
        public bool? AutoPrint { get; set; }
    }
}
