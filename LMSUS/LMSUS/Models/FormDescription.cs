using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class FormDescription
    {
        public long FormId { get; set; }
        public string FormName { get; set; }
        public string FormKeyword { get; set; }
        public string Description { get; set; }
        public long? ParentMenu { get; set; }
    }
}
