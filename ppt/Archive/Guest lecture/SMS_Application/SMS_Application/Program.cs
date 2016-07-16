using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SMService.ServiceClient TestSvcProxy = new SMService.ServiceClient();

                string EmailAddress = "account@gmail.com";
                string Password = "password";
                SMService.CARRIER PROVIDER = SMService.CARRIER.VERIZON; 

                string Phone, Message;

                System.Console.Write("Please enter a phone number: "); 
                Phone = System.Console.ReadLine();

                System.Console.Write("Please enter the phone service provider: ");
                System.Console.ReadLine();

                System.Console.WriteLine("\nPlease enter a message: ");
                Message = System.Console.ReadLine();


                bool Result = TestSvcProxy.SMS(EmailAddress, Password, Phone, PROVIDER, Message);

                if (Result)
                    System.Console.WriteLine("\n\nMessage has been sent.");
            }
            catch (Exception ERROR)
            {
                System.Console.WriteLine(ERROR.Message);
            }
        }
    }
}
