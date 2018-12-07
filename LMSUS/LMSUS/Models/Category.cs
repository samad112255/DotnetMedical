using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class Category
    {
        public long CatId { get; set; }
        public long? CatCode { get; set; }
        public string CatName { get; set; }
        public byte[] CatSymbol { get; set; }
    }
}
