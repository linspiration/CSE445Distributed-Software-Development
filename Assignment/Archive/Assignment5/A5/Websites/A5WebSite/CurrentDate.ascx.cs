using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrentDate : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String date;
        int year, month, day;
        year = DateTime.Now.Year;
        month = DateTime.Now.Month;
        day = DateTime.Now.Day;
        date = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
        lblDate.Text = date;
    }
}