using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net.Mail;

namespace SMS_Service
{
    public class Service : IService
    {
        /// <summary>
        /// Send SMS message via google smtp service
        /// </summary>
        /// <param name="Gmail_Account"></param>
        /// <param name="Password"></param>
        /// <param name="Phone"></param>
        /// <param name="Provider"></param>
        /// <param name="Message"></param>
        /// <returns></returns>
        public bool SMS(string Gmail_Account, string Password, string Phone, CARRIER Provider, string Message)
        {
            try
            {
                string Receiver = Phone;

                switch (Provider)
                {
                    // T-mobile service provider
                    case CARRIER.TMOBILE:
                        Receiver += "@tmomail.net";
                        break;
                    // Sprint service provider
                    case CARRIER.SPRINT:
                        Receiver += "@messaging.sprintpcs.com";
                        break;
                    // Verizon service provider
                    case CARRIER.VERIZON:
                        Receiver += "@vtext.com";
                        break;
                    // AT&T service provider
                    case CARRIER.ATT:
                        Receiver += "@txt.att.net";
                        break;
                    default:
                        throw new Exception("Invalid service provider");
                }

                return Mail(Gmail_Account, Password, Receiver, String.Format("{0} Message: ", Gmail_Account), Message);
            }
            catch (Exception ERROR)
            {
                throw new FaultException(ERROR.Message);
            }
        }

        /// <summary>
        /// Send mail via google account
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        /// <param name="Sender"></param>
        /// <param name="Receiver"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <returns></returns>
        private bool Mail(string Account, string Password, string Receiver, string Subject, string Body)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(Account);
            msg.To.Add(new MailAddress(Receiver));
            msg.Subject = Subject;
            msg.Body = Body;
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.EnableSsl = true;
            smtp.Port = 587;
            // smtp.Port = 25;
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com";

            System.Net.NetworkCredential MailAuthenication = new System.Net.NetworkCredential(Account, Password);
            smtp.Credentials = MailAuthenication;

            try
            {
                smtp.Send(msg);
            }
            catch (Exception ErrorMsg)
            {
                throw new Exception(ErrorMsg.Message);
            }

            return true;
        }
    }
}
