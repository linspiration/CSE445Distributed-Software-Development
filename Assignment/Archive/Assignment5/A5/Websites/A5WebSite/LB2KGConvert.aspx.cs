using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment5Library;
public partial class LB2KBConvert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double value1;
        double value2;
        if (RadioButtonList1.SelectedIndex == 0)
        {
            TextBox2.Text = "";
            value1 = double.Parse(TextBox1.Text);
            TextBox2.Text = JiaqiFunctions.LBsToKg(value1).ToString();
        }
        else if (RadioButtonList1.SelectedIndex == 1)
        {
            TextBox2.Text = "";
            value2 = double.Parse(TextBox1.Text);
            TextBox2.Text = JiaqiFunctions.KgToLBs(value2).ToString();
        }
    }
}