using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
   public class TotalValueModel
    {
        public decimal Name { get; set; }
        public double Value { get; set; }
        public IList Hub { get; set; }

        public TotalValueModel(decimal name, double value, IList hub)
        {
            Name = name;
            Value = value;
            Hub = hub;
        }
    }
}
