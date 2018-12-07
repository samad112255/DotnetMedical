using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ClinicalTest
    {
        public ClinicalTest()
        {
            ClinicalTestRefLabMapping = new HashSet<ClinicalTestRefLabMapping>();
            GroupDetail = new HashSet<GroupDetail>();
            MachineTests = new HashSet<MachineTests>();
            TestResultRange = new HashSet<TestResultRange>();
        }

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
        public string ROCode { get; set; }
        public bool? IsSendOutTest { get; set; }
        public string IsGrouped { get; set; }
        public string TestTypeName { get; set; }
        public decimal? Days { get; set; }
        public bool? Monday { get; set; }
        public bool? Tuesday { get; set; }
        public bool? Wednesday { get; set; }
        public bool? Thursday { get; set; }
        public bool? Friday { get; set; }
        public bool? Saturday { get; set; }
        public bool? Sunday { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string LoincCode { get; set; }
        public string CalFormulaFrom { get; set; }
        public string CalFormulaTo { get; set; }
        public bool? CalFormulaActive { get; set; }

        public ClinicalTestAutoVerificationTypes ResultVerificationType { get; set; }
        public ReportTest ReportTest { get; set; }
        public WorkSheetTest WorkSheetTest { get; set; }
        public ICollection<ClinicalTestRefLabMapping> ClinicalTestRefLabMapping { get; set; }
        public ICollection<GroupDetail> GroupDetail { get; set; }
        public ICollection<MachineTests> MachineTests { get; set; }
        public ICollection<TestResultRange> TestResultRange { get; set; }
    }
}
