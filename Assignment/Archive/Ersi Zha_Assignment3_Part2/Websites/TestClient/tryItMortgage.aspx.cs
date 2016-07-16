using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tryItMortage : System.Web.UI.Page
{
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        ErsiService.ServiceClient client = new ErsiService.ServiceClient();
        double interests;
        double loanAmount;
        double annualTax;
        double annualInsurance;
        int years=Convert.ToInt32(Years.Text);
        if (Interest.Text != "")
            interests = Convert.ToDouble(Interest.Text);
        else interests = 0;
        if (LoanAmount.Text != null)
            loanAmount = Convert.ToDouble(LoanAmount.Text);
        else loanAmount = 0;
        if (AnnualTax.Text != "")
            annualTax = Convert.ToDouble(AnnualTax.Text);
        else annualTax = 0;
        if (AnnualInsurance.Text!="")
            annualInsurance = Convert.ToDouble(AnnualInsurance.Text);
        else annualInsurance=0;

        String[] result=client.monthlyMortgageCalculation(years, interests, loanAmount, annualTax, annualInsurance);
        MonthyTax.Text = result[0];
        MonthyInsurance.Text = result[1];
        MontylyPrincipalAndInterest.Text = result[2];
        TotalPayment.Text = result[3];
    }
}