using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment5Library;

public partial class KM2MileConvert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        TextBox2.Text = DaqiFunctions.KMToMile(TextBox1.Text);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox4.Text = DaqiFunctions.MileToKM(TextBox3.Text);
    }
}