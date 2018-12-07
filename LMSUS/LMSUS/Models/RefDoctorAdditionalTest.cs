using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class RefDoctorAdditionalTest
    {
        public long RefDocAddTestId { get; set; }
        public long? AdocId { get; set; }
        public string AdditionalTest { get; set; }
        public decimal? Type { get; set; }

        public RefDoctor Adoc { get; set; }
    }
}
