using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using System.IO;
using System.Xml;

public partial class Account_Register : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
    }

    protected void RegisterUser_CreatedUser(object sender, EventArgs e)
    {
        FormsAuthentication.SetAuthCookie(RegisterUser.UserName, createPersistentCookie: false);

        string continueUrl = RegisterUser.ContinueDestinationPageUrl;
        if (!OpenAuth.IsLocalUrl(continueUrl))
        {
            continueUrl = "~/";
        }
        ////xml
        string name = RegisterUser.UserName;
        string loc = @"App_Data\Users\" + name + ".xml";
        string fLocation = Path.Combine(Request.PhysicalApplicationPath, loc);

        if (!File.Exists(fLocation))
        {
            //File.Delete(fLocation);
            FileStream fState = null;
            try
            {
                fState = new FileStream(fLocation, FileMode.CreateNew);
                XmlTextWriter writer = new XmlTextWriter(fState, System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();

                writer.WriteStartElement("Name");

                writer.WriteStartElement("Tool1");
                writer.WriteElementString("Price", "1");
                writer.WriteElementString("Bought", "0");
                writer.WriteEndElement();

                writer.WriteStartElement("Tool2");
                writer.WriteElementString("Price", "1");
                writer.WriteElementString("Bought", "0");
                writer.WriteEndElement();

                writer.WriteStartElement("Tool3");
                writer.WriteElementString("Price", "1");
                writer.WriteElementString("Bought", "0");
                writer.WriteEndElement();

                writer.WriteStartElement("Tool4");
                writer.WriteElementString("Price", "1");
                writer.WriteElementString("Bought", "0");
                writer.WriteEndElement();

                writer.WriteStartElement("Tool5");
                writer.WriteElementString("Price", "1");
                writer.WriteElementString("Bought", "0");
                writer.WriteEndElement();

                writer.WriteStartElement("Tool6");
                writer.WriteElementString("Price", "1");
                writer.WriteElementString("Bought", "0");
                writer.WriteEndElement();

                writer.WriteStartElement("Tool7");
                writer.WriteElementString("Price", "1");
                writer.WriteElementString("Bought", "0");
                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteEndDocument();

                writer.Close();
                fState.Close();
            }
            finally
            {
                fState.Close();
            }
        }

        ////xml
        Response.Redirect(continueUrl);
    }
}