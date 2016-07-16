using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class HeightWeightEvaluation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox7.Text = "";
        string url = "http://webstrar21.fulton.asu.edu/page0/page02/Service.svc/input?height=" + TextBox5.Text + "&weight=" + TextBox6.Text;
        XmlTextReader reader = new XmlTextReader(url);
        while (reader.Read())
        {
            TextBox7.Text += reader.Value;
        }
    }
}