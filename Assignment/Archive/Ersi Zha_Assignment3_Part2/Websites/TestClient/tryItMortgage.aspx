<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tryItMortgage.aspx.cs" Inherits="tryItMortage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            font-size: x-large;
        }
        .auto-style4
        {
            color: #0000FF;
        }
        .auto-style2
        {
            color: #0000FF;
        }
        .auto-style5
        {
            color: #CC3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Welcome to the Test Client of Mortgage Calculation Service!</strong></div>
        <p accesskey="Use this Web service to figure out your monthly mortgage payment ">
            <strong><span class="auto-style4">Mortage Calculator Service</span>:</strong><wsdl:documentation xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" style="color: rgb(0, 0, 0); font-family: Times; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px;">Use this service to figure out your monthly mortgage payment</wsdl:documentation><span style="color: rgb(0, 0, 0); font-family: Times; font-size: medium; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;"><span class="Apple-converted-space">&nbsp;</span></span></p>
        <p accesskey="Use this Web service to figure out your monthly mortgage payment ">
            <span class="auto-style2"><strong>Operation</strong></span>: string[] monthlyMortgageCalculation (int years, double interest,double loanAmount,double annualTax,double insurance);<span class="auto-style2"> <strong>Input</strong></span>: five strings <span class="auto-style2"><strong>Output</strong></span>: the information about MonthlyPrincipalAndInterest and TotalPayment</p>
        <p accesskey="Use this Web service to figure out your monthly mortgage payment ">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#CC3300" Text="Input information here(input numbers only):"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Years:          "></asp:Label>
        <asp:TextBox ID="Years" runat="server" Width="318px"></asp:TextBox>
&nbsp;
        <p>
            <asp:Label ID="Label3" runat="server" Text="Interest:"></asp:Label>
            <asp:TextBox ID="Interest" runat="server" Width="304px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="LoanAmount:"></asp:Label>
            <asp:TextBox ID="LoanAmount" runat="server" Width="240px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="AnnualTax:"></asp:Label>
            <asp:TextBox ID="AnnualTax" runat="server" Width="260px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="AnnualInsurance:"></asp:Label>
            <asp:TextBox ID="AnnualInsurance" runat="server" Width="188px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate!" />
        </p>
        <p class="auto-style5">
            <strong>Result:</strong></p>
        <p class="auto-style5">
            <asp:Label ID="Label7" runat="server" Font-Bold="False" ForeColor="Black" Text="MonthlyTax:"></asp:Label>
            <strong>
            <asp:Label ID="MonthyTax" runat="server"></asp:Label>
            </strong>
        </p>
        <p class="auto-style5">
            <asp:Label ID="Label8" runat="server" Font-Bold="False" ForeColor="Black" Text="MonthlyInsurance:"></asp:Label>
            <asp:Label ID="MonthyInsurance" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p class="auto-style5">
            <asp:Label ID="Label9" runat="server" Font-Bold="False" ForeColor="Black" Text="MonthlyPrincipalAndInterest:"></asp:Label>
            <asp:Label ID="MontylyPrincipalAndInterest" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p class="auto-style5">
            <asp:Label ID="Label10" runat="server" Font-Bold="False" ForeColor="Black" Text="TotalPayment(include tax and insurance):"></asp:Label>
            <asp:Label ID="TotalPayment" runat="server" Font-Bold="True"></asp:Label>
        </p>
    </form>
</body>
</html>
