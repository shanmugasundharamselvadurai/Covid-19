using Covid19Tracker.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
   public class RecoveredModel:BasePageModel
    {
        public string provinceState { get; set; }
        public string countryRegion { get; set; }
        public object lastUpdate { get; set; }
        public double lat { get; set; }
        public double @long { get; set; }
        public int confirmed { get; set; }
        public int recovered { get; set; }
        public int deaths { get; set; }
        public int active { get; set; }
        public object admin2 { get; set; }
        public object fips { get; set; }
        public object combinedKey { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
    }
}
