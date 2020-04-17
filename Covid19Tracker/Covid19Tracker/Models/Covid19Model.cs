using Covid19Tracker.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
   public  class Covid19Model
    {
        public Confirmed confirmed { get; set; }
        public Recovered recovered { get; set; }
        public Deaths deaths { get; set; }
        public string dailySummary { get; set; }
        public DailyTimeSeries dailyTimeSeries { get; set; }
        public string image { get; set; }
        public string source { get; set; }
        public string countries { get; set; }
        public CountryDetail countryDetail { get; set; }
        public DateTime lastUpdate { get; set; }

    }
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

    public class DailyTimeSeries
    {
        public string pattern { get; set; }
        public string example { get; set; }
    }

    public class CountryDetail
    {
        public string pattern { get; set; }
        public string example { get; set; }
    }

}

