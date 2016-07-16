using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tryItWeatherForecast : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void StemBtn_Click(object sender, EventArgs e)
    {
        ErsiService1.ServiceClient client = new ErsiService1.ServiceClient();
        String result = client.Stemming(StemInput.Text);
        StemResult.Text = result;
    }
}