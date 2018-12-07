using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class BarcodeLocation
    {
        public long BarcodeLoactionId { get; set; }
        public string DocumentName { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public long DocumentType { get; set; }
        public decimal BarcodeAngle { get; set; }
        public decimal BarcodeAngleTolerance { get; set; }

        public BarcodeLoacationType DocumentTypeNavigation { get; set; }
    }
}
