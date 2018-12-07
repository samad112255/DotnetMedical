using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class FaxReportCriteriaAccessions
    {
        public long FaxReportCriteriaAccessionId { get; set; }
        public string AccesionNo { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string FaxNumber { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public long FaxReportCriteriaId { get; set; }

        public FaxReportCriteria FaxReportCriteria { get; set; }
    }
}
