using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTemperatureConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a proxy to the service
            myServiceRef.ServiceClient myWCfProxy = new myServiceRef.ServiceClient();
            
            //call service operations through the proxy
            Int32 Celsius1 = 32;
            Int32 Fahrenheit1 = myWCfProxy.c2f(Celsius1);
            Int32 Fahrenheit2 = 45;
            Int32 Celsius2 = myWCfProxy.f2c(Fahrenheit2);
            Console.WriteLine("Celsius{0} = Fahrenheit{1} and Fahrenheit{2}=Celsius{3}", Celsius1, Fahrenheit1, Fahrenheit2, Celsius2);
            myWCfProxy.Close();
            Console.WriteLine("Press <Enter> to terminate the client");
            Console.ReadLine();
        }
    }
}
