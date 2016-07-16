using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    string indexKey ;
    ArrayList a = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        for (Int16 i = 1; i <= Session.Count; i++)
        {
            indexKey = "sTool" + i;
            Tool aTool = (Tool)Session[indexKey];
            if (aTool._InCart)
            {
                ListBox1.Items.Add(aTool._name);
                a.Add(aTool._url);
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (ListBox1.SelectedIndex < 0)
            Label1.Text = "Please select a book in the list above";
        else
        {
            int i=ListBox1.SelectedIndex;
            String url = a[i].ToString();
            Response.Redirect(url);
        }
    }
}