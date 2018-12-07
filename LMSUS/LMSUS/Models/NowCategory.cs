using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class NowCategory
    {
        public NowCategory()
        {
            NowCategorymodule = new HashSet<NowCategorymodule>();
            NowClient = new HashSet<NowClient>();
            NowLabitemcategory = new HashSet<NowLabitemcategory>();
            NowLabitemrequest = new HashSet<NowLabitemrequest>();
            NowPatwebreq = new HashSet<NowPatwebreq>();
            NowPatwebreqbatch = new HashSet<NowPatwebreqbatch>();
        }

        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public string Uic { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Zip { get; set; }
        public string Pocname { get; set; }
        public string Poctel { get; set; }
        public string Pocemail { get; set; }
        public string Vpocname { get; set; }
        public string Vpoctel { get; set; }
        public string Vpocemail { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IsDeleted { get; set; }
        public long? CompanyId { get; set; }
        public int? Active { get; set; }
        public long? CategoryStateId { get; set; }
        public string CategoryCity { get; set; }
        public long? CategoryTypeId { get; set; }

        public NowCategorytype CategoryType { get; set; }
        public ICollection<NowCategorymodule> NowCategorymodule { get; set; }
        public ICollection<NowClient> NowClient { get; set; }
        public ICollection<NowLabitemcategory> NowLabitemcategory { get; set; }
        public ICollection<NowLabitemrequest> NowLabitemrequest { get; set; }
        public ICollection<NowPatwebreq> NowPatwebreq { get; set; }
        public ICollection<NowPatwebreqbatch> NowPatwebreqbatch { get; set; }
    }
}
