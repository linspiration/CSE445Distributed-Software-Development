using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    string indexKey;
    protected void Page_Load(object sender, EventArgs e)
    {

        System.DateTime startTime = (System.DateTime)Application["StartTime"];
        System.DateTime endTime = System.DateTime.Now;
        System.TimeSpan ts = (endTime - startTime);
        string time = new DateTime(ts.Ticks).ToString("HH:mm:ss");
        Label3.Text = "Duration in this session: " + time;
        Label4.Text = "Total visit times: " + Application["SessionUsedCount"].ToString();
        if (ListBox1.Items.Count == 0)
        {
            Tool tool1 = new Tool("Tip Calculator", 1, "TipCalculator.aspx",1);
            Tool tool2 = new Tool("Monthly Mortgage Calculator", 1, "MortgageCalculator.aspx",2);
            Tool tool3 = new Tool("Find the nearest store information", 1,"StoreLocator.aspx",3);
            Tool tool4 = new Tool("KM-Mile Convert Tool", 1, "KM2MileConvert.aspx", 4);
            Tool tool5 = new Tool("Height-Weight Evaluation", 1, "HeightWeightEvaluation.aspx", 5);
            Tool tool6 = new Tool("LB-KG Convert Tool", 1, "LB2KGConvert.aspx", 6);
            Tool tool7 = new Tool("Days Calculate Tool", 1, "CalculateDays.aspx", 7);

            Tool[] toolList = { tool1, tool2, tool3,tool4,tool5,tool6,tool7 };


            for (int i = 0; i < 7; i++)
            {
                string num = Convert.ToString(Session.Count + 1); // Find the next free spot
                string catalogKey = "sTool" + num;  // Form the index key for next session spot
                Session[catalogKey] = toolList[i];
                ListBox1.Items.Add(toolList[i]._name);

            }
            Label1.Text = "N/A";
            Label2.Text = "N/A";
        }
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string num = Convert.ToString(ListBox1.SelectedIndex + 1);
        indexKey = "sTool" + num;  // Find selected book
        Tool sTool = (Tool)Session[indexKey]; // read from state variable
        sTool._InCart = true;		        // add information
        Session[indexKey] = sTool;	        // Write back
       // Response.Redirect("ShoppingCart.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedIndex < 0)
            Label1.Text = "Please select a book in the list above";
        else
        {
            string num = Convert.ToString(ListBox1.SelectedIndex + 1);
            indexKey = "sTool" + num;  // Find the selected book
            Tool tool = (Tool)Session[indexKey];
            Label1.Text = tool._name;
            Label2.Text = tool._price.ToString();
        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShoppingCart.aspx");
    }


    protected void Button4_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Protected/admin.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/MainPage.aspx");
    }
}