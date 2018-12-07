using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class BarcodeLoacationType
    {
        public BarcodeLoacationType()
        {
            BarcodeLocation = new HashSet<BarcodeLocation>();
        }

        public long BarcodeLocationTypeId { get; set; }
        public string BarcodeLocationType { get; set; }

        public ICollection<BarcodeLocation> BarcodeLocation { get; set; }
    }
}
