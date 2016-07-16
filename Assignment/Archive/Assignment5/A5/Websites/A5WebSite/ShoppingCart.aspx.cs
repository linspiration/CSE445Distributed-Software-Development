using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Double totalAmount = 0;
        for (Int16 i = 1; i <= Session.Count; i++)
        {
            string indexKey = "sTool" + i;
            Tool aTool = (Tool)Session[indexKey];
            if (aTool._InCart)
            {
                ListBox1.Items.Add(aTool._name);
                totalAmount = totalAmount + Convert.ToDouble(aTool._price);
            }

        }
        Label1.Text = "Total Amount: " + Convert.ToString(totalAmount);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx"); 
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
       bool[] isInCart = new bool[] { false, false, false, false, false, false, false,false};

        for (Int16 i = 1; i <= Session.Count; i++)
        {
            string indexKey = "sTool" + i;
            Tool aTool = (Tool)Session[indexKey];
            isInCart[i - 1] = aTool._InCart;
        }

        /////xml
        string name="";
        name = (string)Application["UserName"];///////////
        if (!name.Equals(""))
        {
            XmlDocument doc = new XmlDocument();
            string loc = @"~/App_Data/Users/" + name + ".xml";
            doc.Load(HostingEnvironment.MapPath(loc));
            Console.WriteLine(doc.LocalName);
            XmlNode root = doc.DocumentElement;
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    if (isInCart[i])
                    {
                        root.ChildNodes[i].LastChild.InnerText = "1";
                    }
                }
            }
            doc.Save(HostingEnvironment.MapPath(loc));

        }
        /// xml

        Response.Redirect("Checkout.aspx");
    }
    

}