using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ErsiLibrary;
using System.Xml;
using System.Collections;
public partial class tryIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Search_Click(object sender, EventArgs e)
    {
        String zipcode = ZipcodeText.Text;
        String storename = StoreText.Text;
        String message = findNearestStore(zipcode, storename);
        result1.Text = message;
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
               // double distance = Convert.ToDouble(sortedList.GetKey(0));
                //if distance<=20 miles return the result else return null
              //  if (distance <= 20)
                    result = sortedList.GetByIndex(0).ToString()+"\n";
              //  else
               //     result = "";
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

    protected void ZipcodeText_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Calculate1_Click(object sender, EventArgs e)
    {
        int numberOfGuests = Convert.ToInt32(NumberOfGuests.Text);
        double tipRate;
        double totalBill;
        double tax;
        double deduction;
        if (TipRate.Text != "")
            tipRate = Convert.ToDouble(TipRate.Text);
        else tipRate = 0;
        if (TotalBill.Text != "")
            totalBill = Convert.ToDouble(TotalBill.Text);
        else totalBill = 0;
        if (Tax.Text != "")
            tax = Convert.ToDouble(Tax.Text);
        else tax = 0;
        if (BillDeduction.Text != "")
            deduction = Convert.ToDouble(BillDeduction.Text);
        else deduction = 0;
        String[] result = ErsiFunctions.tipCalculation(numberOfGuests, tipRate, totalBill, tax, deduction);
        totalTip.Text = result[0];
        perPersonTip.Text = result[1];
        total.Text = result[2];
    }
    protected void Calculate2_Click(object sender, EventArgs e)
    {
        double interests;
        double loanAmount;
        double annualTax;
        double annualInsurance;
        int years = Convert.ToInt32(Years.Text);
        if (Interest.Text != "")
            interests = Convert.ToDouble(Interest.Text);
        else interests = 0;
        if (LoanAmount.Text != null)
            loanAmount = Convert.ToDouble(LoanAmount.Text);
        else loanAmount = 0;
        if (AnnualTax.Text != "")
            annualTax = Convert.ToDouble(AnnualTax.Text);
        else annualTax = 0;
        if (AnnualInsurance.Text != "")
            annualInsurance = Convert.ToDouble(AnnualInsurance.Text);
        else annualInsurance = 0;

        String[] result = ErsiFunctions.monthlyMortgageCalculation(years, interests, loanAmount, annualTax, annualInsurance);
        MonthyTax.Text = result[0];
        MonthyInsurance.Text = result[1];
        MontylyPrincipalAndInterest.Text = result[2];
        TotalPayment.Text = result[3];
    }
}