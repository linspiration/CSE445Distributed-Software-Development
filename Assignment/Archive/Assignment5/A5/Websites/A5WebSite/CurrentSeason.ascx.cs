using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrentSeason : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String month = "Month:";
        String season = " ";
        Int32 m = DateTime.Now.Month;
        month += m.ToString();
        if (m >= 3 && m <= 5)
        {
            season += "Spring";
        }
        else if (m >= 6 && m <= 8)
        {
            season += "Summer";
        }
        else if (m >= 9 && m <= 11)
        {
            season += "Autumn";
        }
        else
        {
            season += "Winter";
        }
      
        lblSeason.Text = season;
    }
}