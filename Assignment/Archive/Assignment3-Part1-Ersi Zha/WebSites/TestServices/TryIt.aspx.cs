using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class TryIt : System.Web.UI.Page
{
    ErsiService.ServiceClient client = new ErsiService.ServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void StemBtn_Click(object sender, EventArgs e)
    {
        String result=client.Stemming(StemInput.Text);
        StemResult.Text = result;
    }
    protected void WeahterBtn_Click(object sender, EventArgs e)
    {
        Label[] weatherResults = new Label[5] { WeatherResult1, WeatherResult2, WeatherResult3, WeatherResult4, WeatherResult5 };
        String zipcode=WeatherInput.Text;
        String[] result=client.Weather5day(zipcode);
        for (int i = 0; i < result.Length; i++) 
            weatherResults[i].Text = result[i];
    }
}