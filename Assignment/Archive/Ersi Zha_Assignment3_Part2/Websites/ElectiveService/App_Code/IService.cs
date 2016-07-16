using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    //Part2(Elective service):Mortgage Calculation Service 
    [OperationContract]
    string[] monthlyMortgageCalculation (int years, double interest,double loanAmount,double annualTax,double insurance);
    //Part2(Elective service):tip Calculation Service 
    [OperationContract]
    string[] tipCalculation(int numberOfGuests, double tipRate, double billTotal, double tax, double billDeduction);
 
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
