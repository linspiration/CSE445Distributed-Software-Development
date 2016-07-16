using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment5Library;
public partial class TipCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
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
}