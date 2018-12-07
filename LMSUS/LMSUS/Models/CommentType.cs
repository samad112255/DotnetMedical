using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class CommentType
    {
        public CommentType()
        {
            Comments = new HashSet<Comments>();
        }

        public long CtId { get; set; }
        public string CtCode { get; set; }
        public string CtName { get; set; }
        public string CtDescription { get; set; }

        public ICollection<Comments> Comments { get; set; }
    }
}
