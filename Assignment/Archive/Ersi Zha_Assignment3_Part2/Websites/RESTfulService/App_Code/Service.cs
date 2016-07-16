using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;
using System.Xml;
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
    //Part2( Elective RESTful Service):Store Locator Service
    public string findNearestStore(string zipcode, string storeName)
    {
        string result = "";
        try
        {
            string[] cityInfo = getCityInfo(zipcode);
            string cityName = cityInfo[0];
            string stateName = cityInfo[1];
            string key = "AsegIlDrkrt0uVT9UbU6_v-KV4QdoS_1VYax6Yc681BOrAp-gSmUqy4_PWPECMVm";
            // Set the credentials using a valid Bing Maps key
            BingSearch.SearchRequest searchRequest = new BingSearch.SearchRequest();
            searchRequest.Credentials = new BingSearch.Credentials();
            searchRequest.Credentials.ApplicationId = key;
            searchRequest.Query = storeName + " in " + cityName + " ," + stateName;
            searchRequest.SearchOptions = new BingSearch.SearchOptions();
            searchRequest.SearchOptions.Filters = new BingSearch.FilterExpression()
            {
                PropertyId = 3,
                CompareOperator = BingSearch.CompareOperator.GreaterThanOrEquals,
                FilterValue = 8
            };
            // Make the search request
            BingSearch.SearchServiceClient searchClient = new BingSearch.SearchServiceClient("BasicHttpBinding_ISearchService");
            BingSearch.SearchResponse searchResponse = searchClient.Search(searchRequest);
            BingSearch.SearchResultBase[] resultBase = searchResponse.ResultSets[0].Results;
            string resultList = "";
            //define a sortedList to sort the message by distance
            SortedList sortedList = new SortedList();
            if (resultBase.Length > 0)
            {
                for (int i = 0; i < resultBase.Length; i++)
                {
                    BingSearch.BusinessSearchResult bsr = resultBase[i] as BingSearch.BusinessSearchResult;
                    resultList = "Stores name: " + resultBase[i].Name + "; Address: " + bsr.Address.FormattedAddress
                        + "; Distance:" + resultBase[i].Distance + "miles" + "\n";
                    if (!sortedList.ContainsKey(resultBase[i].Distance))
                        sortedList.Add(resultBase[i].Distance, resultList);
                }
                //return the nearest store message 
                double distance = Convert.ToDouble(sortedList.GetKey(0));
                //if distance<=20 miles return the result else return null
                if (distance <= 20)
                    result = sortedList.GetByIndex(0).ToString();
                else
                    result = "";
            }
            else
                result = "";
            sortedList.Clear();
        }
        catch (Exception ex)
        {
            result = "An exception occurred: " + ex.Message;
        }

        return result;

    }

    private string[] getCityInfo(String zipcode)
    {
        String[] info = new String[2];
        CityInfoService.USZipSoapClient cityInfoClient = new CityInfoService.USZipSoapClient("USZipSoap");
        cityInfoClient.GetInfoByZIP(zipcode);
        XmlNode nodes = cityInfoClient.GetInfoByZIP(zipcode);
        if (nodes.HasChildNodes)
        {
            XmlNodeList childNodes = nodes.ChildNodes.Item(0).ChildNodes;
            XmlNode node0 = childNodes.Item(0);
            XmlNode node1 = childNodes.Item(1);
            //get the city and state value
            info[0] = node0.InnerText;
            info[1] = node1.InnerText;
        }
        return info;
    }
}
