using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookies = Request.Cookies["myKeyie"];
        if ((myCookies == null) || (myCookies["Name"] == ""))
        {
            Label1.Text = "Welcome, new user";
        }
        else
        {
            Label1.Text = "Welcome, " + myCookies["Name"];
        }	

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text))
        {
            HttpCookie myCookies = new HttpCookie("myKeyie");
            myCookies["Name"] = txtUserName.Text;
            myCookies.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(myCookies);
            Output.Text = "Login Successfully!";
            Label1.Text = "Name stored in Cookie " + myCookies["Name"];
        }
        else
            Output.Text = "Invalid login";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        HttpCookie myCookies = new HttpCookie("myKeyie");
        Response.Cookies.Clear();
        Response.Redirect("~/MainPage.aspx");
    }
}