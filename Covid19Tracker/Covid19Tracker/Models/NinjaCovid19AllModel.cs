using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
   public class NinjaCovid19AllModel
   {
        public int cases { get; set; }
        public int deaths { get; set; }
        public int recovered { get; set; }
        public long updated { get; set; }
        public int active { get; set; }

    }
}