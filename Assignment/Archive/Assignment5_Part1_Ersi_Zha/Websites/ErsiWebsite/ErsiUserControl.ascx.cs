using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ErsiUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 Hour = DateTime.Now.Hour;
        Int32 Minute = DateTime.Now.Minute;
        Int32 Second = DateTime.Now.Second;
        String CurrentTime = Hour.ToString() +":"+ Minute.ToString()+":" + Second.ToString();
        lblCurrentTime.Text = CurrentTime;
    }
}