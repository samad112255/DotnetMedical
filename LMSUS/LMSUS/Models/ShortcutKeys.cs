using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class ShortcutKeys
    {
        public long Id { get; set; }
        public string ShortcutKey { get; set; }
        public string Functionality { get; set; }
        public string KeysCode { get; set; }
    }
}
