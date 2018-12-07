using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ClinicalTestBackup
    {
        public long TestId { get; set; }
        public decimal? TestCode { get; set; }
        public string TestName { get; set; }
        public string TestShortName { get; set; }
        public decimal? ClId { get; set; }
        public bool? CheckRange { get; set; }
        public bool? PrintRange { get; set; }
        public bool? ExtRange { get; set; }
        public string ExtRangeDesc { get; set; }
        public bool? AgeRange { get; set; }
        public string MHigh { get; set; }
        public string MLow { get; set; }
        public string MNormal { get; set; }
        public string MCHigh { get; set; }
        public string MCLow { get; set; }
        public string MCNormal { get; set; }
        public string FHigh { get; set; }
        public string FLow { get; set; }
        public string FNormal { get; set; }
        public string FCHigh { get; set; }
        public string FCLow { get; set; }
        public string FCNormal { get; set; }
        public string Comments { get; set; }
        public string DefaultVal { get; set; }
        public decimal? AutoTest1 { get; set; }
        public decimal? AutoTest2 { get; set; }
        public string ResultValue1 { get; set; }
        public string ResultValue2 { get; set; }
        public string Cond1 { get; set; }
        public string Cond2 { get; set; }
        public string MAssayHigh { get; set; }
        public string MAssayLow { get; set; }
        public string MAssayNormal { get; set; }
        public string FAssayHigh { get; set; }
        public string FAssayLow { get; set; }
        public string FAssayNormal { get; set; }
        public string CalculationFormula { get; set; }
        public string ResFormat { get; set; }
        public string Units { get; set; }
        public string Tube { get; set; }
        public long? ResultVerificationTypeId { get; set; }
        public bool? Commissionable { get; set; }
        public string ExtRangeDescTmp { get; set; }
        public int? DecimalPrecision { get; set; }
        public int? TestResultDecimalPercision { get; set; }
        public bool? AdditionalInfoReq { get; set; }
        public bool? DeltaCheck { get; set; }
        public string DeltaCheckValue { get; set; }
        public bool? IsReflexTest { get; set; }
        public byte? ReflexTestCondition { get; set; }
        public byte? ReflexTestOperator { get; set; }
        public string ReflexTestResultValue { get; set; }
        public long? ReflexTestId { get; set; }
        public bool? Inactive { get; set; }
        public string Status { get; set; }
        public string Tat { get; set; }
    }
}
