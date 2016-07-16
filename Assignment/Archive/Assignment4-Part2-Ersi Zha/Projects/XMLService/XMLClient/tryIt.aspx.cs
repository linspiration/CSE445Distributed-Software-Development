using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMLClient
{
    public partial class tryIt : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            XMLService.ServiceClient xmlService = new XMLService.ServiceClient();
            String Verification = xmlService.Verification(TextBox1.Text, TextBox2.Text);
            Result1.Text = Verification;
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            XMLService.ServiceClient xmlService = new XMLService.ServiceClient();
            String operations = xmlService.SearchWSDL(TextBox3.Text);
            Result2.Text = operations;
        }
    }
}