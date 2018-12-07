using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class CompanyInformation
    {
        public long Pkid { get; set; }
        public string ComName { get; set; }
        public string ComAddress { get; set; }
        public string ComPhone { get; set; }
        public string ComFax { get; set; }
        public string ComEmpId { get; set; }
        public string ComSubmitterId { get; set; }
        public string ComClia { get; set; }
        public bool? BillPen { get; set; }
        public bool? SpUnHold { get; set; }
        public string NoAbmMod { get; set; }
        public string AbmOnFileMod { get; set; }
        public long? ZipId { get; set; }
        public string City { get; set; }
        public string Npinumber { get; set; }
        public string PharmacyProcessorNumber { get; set; }
        public string MedicareNumber { get; set; }
        public string MedicaidNumber { get; set; }
        public string FacilityIdnumber { get; set; }
        public string Upinnumber { get; set; }
        public string ElectronicDevicePin { get; set; }
        public string ProviderPlanNetwrok { get; set; }
        public string FacilityNetworkIdentification { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
    }
}
