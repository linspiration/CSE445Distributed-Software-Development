using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using com.cdyne.wsf;





// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        if (composite == null)
        {
            throw new ArgumentNullException("composite");
        }
        if (composite.BoolValue)
        {
            composite.StringValue += "Suffix";
        }
        return composite;
    }
    //Service 14:weather forecast service
    public string[] Weather5day(string zipcode)
    {
        String[] returnInfo = new String[5];
        Forecast[] forecasts;
        Weather weather = new Weather();
        ForecastReturn ForecastsReturn;
        WeatherReturn WeatherReturn;
        WeatherDescription[] WeatherDecription;
        WeatherReturn = weather.GetCityWeatherByZIP(zipcode);
        ForecastsReturn = weather.GetCityForecastByZIP(zipcode);
        WeatherDecription = weather.GetWeatherInformation();
        if (ForecastsReturn.ForecastResult != null)
        {
            forecasts = ForecastsReturn.ForecastResult;
            for (int i = 0; i < 5; i++)
            {
               
                StringBuilder sb = new StringBuilder();
                String Date = "Date:" + forecasts[i].Date + ";";
                String MorningLow = "MorningLow:" + forecasts[i].Temperatures.MorningLow + ";";
                String DaytimeHigh = "DaytimeHigh:" + forecasts[i].Temperatures.DaytimeHigh + ";";
                String Pressure = "Pressure:" + WeatherReturn.Pressure + ";";
                String Humidity = "Humidity:" + WeatherReturn.RelativeHumidity + ";";
                String Wind = "Wind:" + WeatherReturn.Wind + ";";
                String location = "Location:" + WeatherReturn.City + " " + WeatherReturn.State + ";";
                sb.Append(Date);
                sb.Append(location);
                sb.Append(MorningLow);
                sb.Append(DaytimeHigh);
                sb.Append(Pressure);
                sb.Append(Humidity);
                sb.Append(Wind);
                String result = sb.ToString();
                returnInfo[i] = result;
            }
        }
        return returnInfo;
    }
    //Service 3:stemming service
    //Reference from :http://grammar.about.com/od/words/a/comsuffixes.htm
    public string Stemming(string str)
    {
        String result = "";
        String[] splitstr = str.Split(' ');
        String input;
        //Analyze the suffixes about the input words
        for (int i = 0; i < splitstr.Length; i++)
        {
            input = splitstr[i].ToLower();
            int Index = 0;
            if (input.EndsWith("acy") || input.EndsWith("dom") || input.EndsWith("ism") || input.EndsWith("ism")
                || input.EndsWith("ist") || input.EndsWith("ity") || input.EndsWith("ate") || input.EndsWith("ify")
                || input.EndsWith("ful") || input.EndsWith("ous") || input.EndsWith("ish") || input.EndsWith("ive"))
            {
                Index = 3;
            }
            else if (input.EndsWith("al") || input.EndsWith("er") || input.EndsWith("or") || input.EndsWith("en") || input.EndsWith("fy") ||
                input.EndsWith("ic") || input.EndsWith("ed"))
            {
                Index = 2;
            }
            else if (input.EndsWith("ance") || input.EndsWith("ence") || input.EndsWith("ment") || input.EndsWith("ness") || input.EndsWith("ship")
                || input.EndsWith("sion") || input.EndsWith("tion") || input.EndsWith("able") || input.EndsWith("ible") || input.EndsWith("ious") || input.EndsWith("less"))
            {
                Index = 4;
            }
            else if (input.EndsWith("esque"))
            {
                Index = 5;
            }
            else if (input.EndsWith("y"))
            {
                Index = 1;
            }
            if (Index == 0)
            {
                result += " " + input;
            }
            else
            {
                result += " " + input.Substring(0, input.Length - Index);
            }
        }
        return result.Trim();

    }
}