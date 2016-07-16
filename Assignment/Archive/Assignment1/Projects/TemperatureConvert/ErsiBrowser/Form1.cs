using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ErsiBrowser.com.cdyne.wsf;
using System.Net;
using System.IO;
namespace ErsiBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

  
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EncryService.ServiceClient EncryClient = new EncryService.ServiceClient();
            try
            {
                labEncryted.Text = EncryClient.Encrypt(txtInput.Text);
            }
            catch (Exception ec) { labEncryted.Text = ec.Message.ToString(); }
            try
            {
                labDecryted.Text = EncryClient.Decrypt(labEncryted.Text);
            }
            catch (Exception dc) { labDecryted.Text = dc.Message.ToString(); }
       
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            StockQuoteService.StockQuoteSoapClient sqClient
                = new StockQuoteService.StockQuoteSoapClient("StockQuoteSoap");

            String StockQuoteXML = sqClient.GetQuote(txtStockQuote.Text);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(StockQuoteXML);
            XmlNodeList childNodes=doc.ChildNodes;
            txtLast.Text =doc.GetElementsByTagName("Last")[0].InnerText;
            txtDate.Text = doc.GetElementsByTagName("Date")[0].InnerText;
            txtTime.Text = doc.GetElementsByTagName("Time")[0].InnerText;
            txtChange.Text = doc.GetElementsByTagName("Change")[0].InnerText;
            txtOpen.Text = doc.GetElementsByTagName("Open")[0].InnerText;
            txtHigh.Text = doc.GetElementsByTagName("High")[0].InnerText;
            txtLow.Text = doc.GetElementsByTagName("Low")[0].InnerText;
            txtVolume.Text = doc.GetElementsByTagName("Volume")[0].InnerText;
            txtMktcap.Text = doc.GetElementsByTagName("MktCap")[0].InnerText;
            txtPC.Text = doc.GetElementsByTagName("PreviousClose")[0].InnerText;
            txtPC1.Text = doc.GetElementsByTagName("PercentageChange")[0].InnerText;
            txtAnnRange.Text = doc.GetElementsByTagName("AnnRange")[0].InnerText;
            txtEarns.Text = doc.GetElementsByTagName("Earns")[0].InnerText;
            txtPE.Text = doc.GetElementsByTagName("P-E")[0].InnerText;
            txtName.Text = doc.GetElementsByTagName("Name")[0].InnerText; 
        }
       
        private void btnForecast_Click_1(object sender, EventArgs e)
        {
            Forecast[] forecasts;
            Weather weather=new Weather();
            ForecastReturn ForecastsReturn;
            WeatherReturn WeatherReturn;
            Bitmap pic;
            GroupBox[] groupBoxes;
            PictureBox[] pictureBoxes;
            Label[] lowLabels;
            Label[] highLabels;
            Label[] humidityLabels;
            WeatherDescription[] WeatherDecription;
            groupBoxes = new System.Windows.Forms.GroupBox[5] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5 };
            pictureBoxes = new System.Windows.Forms.PictureBox[5] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            lowLabels = new System.Windows.Forms.Label[5] {lowTemp1, lowTemp2, lowTemp3, lowTemp4, lowTemp5 };
            highLabels = new System.Windows.Forms.Label[5] {highTemp1, highTemp2, highTemp3, highTemp4, highTemp5 };
            humidityLabels = new System.Windows.Forms.Label[5] { humidity1, humidity2, humidity3, humidity4, humidity5 };
            WeatherReturn = weather.GetCityWeatherByZIP(txtZip.Text);
            ForecastsReturn = weather.GetCityForecastByZIP(txtZip.Text);
            WeatherDecription = weather.GetWeatherInformation();
            if (ForecastsReturn.ForecastResult != null)
            {

                forecasts = ForecastsReturn.ForecastResult;
                for (int i = 0; i < 5; i++)
                {
                    pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    groupBoxes[i].Text = forecasts[i].Date.ToString();
                    pic = LoadPicture(WeatherDecription[i].PictureURL);
                    pictureBoxes[i].Image = (Image)pic;
                    lowLabels[i].Text = forecasts[i].Temperatures.MorningLow;
                    highLabels[i].Text =forecasts[i].Temperatures.DaytimeHigh;
                    humidityLabels[i].Text = WeatherReturn.RelativeHumidity;
                    labCity.Text = WeatherReturn.City +" "+ WeatherReturn.State;
                }
            }
            else
            {
                MessageBox.Show("No weather information");
            }
        }

        private Bitmap LoadPicture(String url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;
            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;
                wresp = (HttpWebResponse)wreq.GetResponse();
                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            finally
            {
                if (mystream != null) mystream.Close();
                if (wresp != null) wresp.Close();
            }
            return (bmp);
        }

       


      

       

    }
}
