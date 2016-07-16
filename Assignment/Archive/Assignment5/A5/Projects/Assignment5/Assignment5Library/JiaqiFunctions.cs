using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Library
{
   public  class JiaqiFunctions
    {
        public static double KgToLBs(double kg)
        {
            double lbs;
            lbs = Math.Round(kg / 0.454, 3);
            return lbs;
        }

        public static double LBsToKg(double lbs)
        {
            double kg;
            kg = Math.Round(lbs * 0.454, 3);
            return kg;
        }
    }
}
