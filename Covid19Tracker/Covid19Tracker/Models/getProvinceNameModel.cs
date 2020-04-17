using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
  public  class getProvinceNameModel
    {
        [JsonProperty("results")]
        public List<string> results { get; set; }
        [JsonProperty("success")]
        public bool success { get; set; }
    }
}
