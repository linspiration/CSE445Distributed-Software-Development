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
    protected void WeahterBtn_Click(object sender, EventArgs e)
    {
        ErsiService1.ServiceClient client = new ErsiService1.ServiceClient();
        Label[] weatherResults = new Label[5] { WeatherResult1, WeatherResult2, WeatherResult3, WeatherResult4, WeatherResult5 };
        String zipcode = WeatherInput.Text;
        String[] result = client.Weather5day(zipcode);
        for (int i = 0; i < result.Length; i++)
            weatherResults[i].Text = result[i];
    }
}