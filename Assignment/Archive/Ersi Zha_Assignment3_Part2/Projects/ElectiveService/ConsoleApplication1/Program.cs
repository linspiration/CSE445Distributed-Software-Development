using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            String s=client.findNearestStore("85281", "walmart");
            if(s.Equals("")) { Console.WriteLine("no message");}
            Console.WriteLine(s);
        }
    }
}
