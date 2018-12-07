using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Cptcodes
    {
        public long CptcodeId { get; set; }
        public string Cptcode { get; set; }
        public string Cptdescription { get; set; }
        public string Cptcode2 { get; set; }
        public string Cptcode3 { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal? Price4 { get; set; }
        public decimal? Price5 { get; set; }
        public decimal? Price6 { get; set; }
        public decimal? Price7 { get; set; }
        public decimal? Price8 { get; set; }
        public decimal? Price9 { get; set; }
        public decimal? Price10 { get; set; }
        public decimal? Price11 { get; set; }
        public decimal? Price12 { get; set; }
        public decimal? Price13 { get; set; }
        public decimal? Price14 { get; set; }
        public decimal? Price15 { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsLocked { get; set; }
        public long? LockedBy { get; set; }
    }
}
