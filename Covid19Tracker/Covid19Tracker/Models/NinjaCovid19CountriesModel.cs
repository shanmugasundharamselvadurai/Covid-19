using Covid19Tracker.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
   public class NinjaCovid19CountriesModel
   {
        public string country { get; set; }
        public string cases { get; set; }
        public string todayCases { get; set; }
        public string deaths { get; set; }
        public string todayDeaths { get; set; }
        public string recovered { get; set; }
        public string active { get; set; }
        public string critical { get; set; }
        public string casesPerOneMillion { get; set; }
        public string deathsPerOneMillion { get; set; }
        public CountryInfo countryInfo { get; set; }
        public object updated { get; set; }
    }

    public class CountryInfo
    {
        public int? _id { get; set; }
        public string country { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public double lat { get; set; }
        public double @long { get; set; }
        public string flag { get; set; }
    }
}
