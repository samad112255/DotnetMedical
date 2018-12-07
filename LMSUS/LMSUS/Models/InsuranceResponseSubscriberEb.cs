using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class InsuranceResponseSubscriberEb
    {
        public long EligibilityResponseSuscriberEbid { get; set; }
        public long? EligibilityResponseSuscriberEbmainId { get; set; }
        public string BenifitInformationCode { get; set; }
        public string BenifitInformationDesc { get; set; }
        public string CoverageLevel { get; set; }
        public string InsuranceType { get; set; }
        public string PlanCoverageDescription { get; set; }
        public string TimePeriodQualifier { get; set; }
        public string MonetryAmount { get; set; }
        public string AmountPercent { get; set; }
        public string MinimumQty { get; set; }
        public string QuantityUsedQty { get; set; }
        public string CoveredActualQty { get; set; }
        public string CoveredEstimatedQty { get; set; }
        public string NumberOfCoInsuranceDaysQty { get; set; }
        public string DeductableBloodUnitsQty { get; set; }
        public string DaysQty { get; set; }
        public string HoursQty { get; set; }
        public string LifeTimeReservedActualQty { get; set; }
        public string LifeTimeReservedEstimatedQty { get; set; }
        public string MaximumQty { get; set; }
        public string MonthQty { get; set; }
        public string NumberOfServicesOrProceduresQty { get; set; }
        public string QuantityApprovedQty { get; set; }
        public string AgeHighValueQty { get; set; }
        public string AgeLowValueQty { get; set; }
        public string VisitsQty { get; set; }
        public string YearsQty { get; set; }
    }
}
