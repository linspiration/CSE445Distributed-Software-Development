using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	
    //Part2( Elective Service):Mortgage Calculator Service
    public string[] monthlyMortgageCalculation(int years, double interest, double loanAmount, double annualTax, double insurance)
    {
        string[] result = new string[4];
        double MonthlyTax;
        double MonthlyInsurance;
        double MonthlyInterestRate;
        double MonthlyPrincipalAndInterest;
        double TotalPayment;
        int totalMonth;
        //uese Mortgage formula to calculate the result
        totalMonth = years * 12;
        MonthlyTax = annualTax / 12;
        MonthlyInsurance = insurance / 12;
        MonthlyInterestRate = interest / 12 / 100;
        MonthlyPrincipalAndInterest = (loanAmount * MonthlyInterestRate) / (1 - Math.Pow((1 + MonthlyInterestRate), -totalMonth));
        TotalPayment = MonthlyPrincipalAndInterest + MonthlyInsurance + MonthlyTax;
        result[0] = MonthlyTax.ToString();
        result[1] = MonthlyInsurance.ToString();
        result[2] = MonthlyPrincipalAndInterest.ToString();
        result[3] = TotalPayment.ToString();
        return result;
    }
    //Part2(Elective Serice):Tip Calculation Service
    public string[] tipCalculation(int numberOfGuests, double tipRate, double billTotal, double tax, double billDeduction)
    {
        string[] result = new string[3];
        double perPersonTip;
        double totalTip;
        double total;
        totalTip = (billTotal - billDeduction + tax) * tipRate / 100;
        perPersonTip = totalTip / numberOfGuests;
        total = totalTip + billTotal;
        result[0] = totalTip.ToString();
        result[1] = perPersonTip.ToString();
        result[2] = total.ToString();
        return result;
    }
}
