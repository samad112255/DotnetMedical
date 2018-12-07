using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class FaxReportCriteria
    {
        public FaxReportCriteria()
        {
            FaxReportCriteriaAccessions = new HashSet<FaxReportCriteriaAccessions>();
        }

        public long FaxReportCriteriaId { get; set; }
        public string FaxReportCriteria1 { get; set; }
        public DateTime? FaxReprotCreationDate { get; set; }
        public int FaxReportStatus { get; set; }
        public string FaxReportError { get; set; }
        public int FaxReprotType { get; set; }
        public bool? CurrentlyExecuting { get; set; }

        public ICollection<FaxReportCriteriaAccessions> FaxReportCriteriaAccessions { get; set; }
    }
}
