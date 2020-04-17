using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
   public class covid19IndiaModel
   {
        public List<CasesTimeSery> cases_time_series { get; set; }
        public List<KeyValue> key_values { get; set; }
        public List<Statewise> statewise { get; set; }
        public List<Tested> tested { get; set; }
    }
    public class CasesTimeSery
    {
        public string dailyconfirmed { get; set; }
        public string dailydeceased { get; set; }
        public string dailyrecovered { get; set; }
        public string date { get; set; }
        public string totalconfirmed { get; set; }
        public string totaldeceased { get; set; }
        public string totalrecovered { get; set; }
    }

    public class KeyValue
    {
        public string confirmeddelta { get; set; }
        public string counterforautotimeupdate { get; set; }
        public string deceaseddelta { get; set; }
        public string lastupdatedtime { get; set; }
        public string recovereddelta { get; set; }
        public string statesdelta { get; set; }
    }

    public class Delta
    {
        public int active { get; set; }
        public int confirmed { get; set; }
        public int deaths { get; set; }
        public int recovered { get; set; }
    }

    public class Statewise
    {
        public string active { get; set; }
        public string confirmed { get; set; }
        public string deaths { get; set; }
        public string deltaconfirmed { get; set; }
        public string deltadeaths { get; set; }
        public string deltarecovered { get; set; }
        public string lastupdatedtime { get; set; }
        public string recovered { get; set; }
        public string state { get; set; }
        public string statecode { get; set; }
    }

    public class Tested
    {
        public string source { get; set; }
        public string totalindividualstested { get; set; }
        public string totalpositivecases { get; set; }
        public string totalsamplestested { get; set; }
        public string updatetimestamp { get; set; }
    }
}
