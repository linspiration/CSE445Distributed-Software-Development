using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Library
{
    public class DaqiFunctions
    {
        public static string KMToMile(string km)
        {
            return (Convert.ToDouble(km) * 1.609).ToString();
        }

        public static string MileToKM(string mile)
        {
            return (Convert.ToDouble(mile) / 1.609).ToString();
        }
    }
}
