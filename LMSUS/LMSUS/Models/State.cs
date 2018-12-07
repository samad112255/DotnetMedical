using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class State
    {
        public State()
        {
            City = new HashSet<City>();
        }

        public long StId { get; set; }
        public string StName { get; set; }
        public string StFullName { get; set; }

        public ICollection<City> City { get; set; }
    }
}
