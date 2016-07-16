using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Runtime.Serialization;


public partial class tryIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
   
        Uri baseUri = new Uri("http://webstrar21.fulton.asu.edu/page0/page01/Service.svc");
        UriTemplate temp = new UriTemplate("input?zipcode={zipcode}&storeName={storeName}");
        Uri completeUri = temp.BindByPosition(baseUri, ZipcodeText.Text, StoreText.Text);
        WebClient proxy = new WebClient();
        byte[] abc = proxy.DownloadData(completeUri);
        Stream strm = new MemoryStream(abc);
        DataContractSerializer obj = new DataContractSerializer(typeof(string));
        string result = obj.ReadObject(strm).ToString();
        result1.Text = result;

    }
}