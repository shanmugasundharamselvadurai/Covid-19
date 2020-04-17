using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Util
{
    public class CommonUtils
    {
        public CommonUtils()
        {

        }
        public static double ConvertToDouble(string Value)
        {
            if (Value == null)
            {
                return 0;
            }
            else
            {
                double OutVal;
                double.TryParse(Value, out OutVal);

                if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
                {
                    return 0;
                }
                return OutVal;
            }
        }
    }
}
