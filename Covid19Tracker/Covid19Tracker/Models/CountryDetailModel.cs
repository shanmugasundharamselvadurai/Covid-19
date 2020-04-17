using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
   public class CountryDetailModel
    {
        public Confirmed confirmed { get; set; }
        public Recovered recovered { get; set; }
        public Deaths deaths { get; set; }
        public DateTime lastUpdate { get; set; }

        public class Confirmed
        {
            public string value { get; set; }
            public string detail { get; set; }
        }
        public class Recovered
        {
            public string value { get; set; }
            public string detail { get; set; }
        }
        public class Deaths
        {
            public string value { get; set; }
            public string detail { get; set; }
        }
    }
}
