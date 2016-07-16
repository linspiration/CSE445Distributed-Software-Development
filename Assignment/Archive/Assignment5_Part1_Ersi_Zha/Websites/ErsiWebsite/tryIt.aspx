<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tryIt.aspx.cs" Inherits="tryIt" %>
<%@ Register TagPrefix = "time" TagName="CurrentTime" 
			src="ErsiUserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style3
        {
            color: #CC3300;
        }
        .auto-style4
        {
            font-size: medium;
        }
        .auto-style5
        {
            color: #CC3300;
        }
        .auto-style6
        {
            font-size: medium;
        }
        .auto-style7
        {
            color: #0000FF;
        }
        .auto-style8
        {
            font-size: medium;
            color: #0000FF;
        }
        .auto-style9
        {
            color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <strong><span class="auto-style4"><span class="auto-style7">User Control:</span><br />     
        </span></strong><span class="auto-style6">Current Time:</span><span class="auto-style4"><strong><time:CurrentTime ID="CurrentTime1" runat = "server" /></strong><br />
        <span class="auto-style7"><strong>DLL(TipCalculator):</strong></span></span><br />
        <asp:Label ID="Label1" runat="server" Text="Number of Guests:"></asp:Label>
        <asp:TextBox ID="NumberOfGuests" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" BorderStyle="None" Text="Tip Rate:"></asp:Label>
            <asp:TextBox ID="TipRate" runat="server" Width="354px"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" Text="%"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Total Bill:"></asp:Label>
            <asp:TextBox ID="TotalBill" runat="server" Width="336px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Tax:"></asp:Label>
            <asp:TextBox ID="Tax" runat="server" Width="406px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Bill Deductions:"></asp:Label>
            <asp:TextBox ID="BillDeduction" runat="server" Width="260px"></asp:TextBox>
            <asp:Button ID="Calculate1" runat="server" OnClick="Calculate1_Click" Text="Calculate!" />
        </p>
        <p class="auto-style3">
            <strong>Result:</strong></p>
        <asp:Label ID="Label6" runat="server" Text="perPersonTip :"></asp:Label>
        <asp:Label ID="perPersonTip" runat="server"></asp:Label>
        <p>
            <asp:Label ID="Label7" runat="server" Text="totalTip :"></asp:Label>
            <asp:Label ID="totalTip" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="total payment(bill and tip) :"></asp:Label>
            <asp:Label ID="total" runat="server"></asp:Label>
        </p>
        <p>
            <strong><span class="auto-style8">DLL(Mortgage calculator):</span></strong></p>
    <div>
    
        <asp:Label ID="Label11" runat="server" Text="Years:          "></asp:Label>
        <asp:TextBox ID="Years" runat="server" Width="318px"></asp:TextBox>
        &nbsp;
        <p>
            <asp:Label ID="Label12" runat="server" Text="Interest:"></asp:Label>
            <asp:TextBox ID="Interest" runat="server" Width="304px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label13" runat="server" Text="LoanAmount:"></asp:Label>
            <asp:TextBox ID="LoanAmount" runat="server" Width="240px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label14" runat="server" Text="AnnualTax:"></asp:Label>
            <asp:TextBox ID="AnnualTax" runat="server" Width="260px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label15" runat="server" Text="AnnualInsurance:"></asp:Label>
            <asp:TextBox ID="AnnualInsurance" runat="server" Width="188px"></asp:TextBox>
            <asp:Button ID="Calculate2" runat="server" OnClick="Calculate2_Click" Text="Calculate" />
        </p>
        <p class="auto-style5">
            <strong>Result:</strong></p>
        <p class="auto-style5">
            <asp:Label ID="Label16" runat="server" Font-Bold="False" ForeColor="Black" Text="MonthlyTax:"></asp:Label>
            <strong>
            <asp:Label ID="MonthyTax" runat="server"></asp:Label>
            </strong>
        </p>
        <p class="auto-style5">
            <asp:Label ID="Label17" runat="server" Font-Bold="False" ForeColor="Black" Text="MonthlyInsurance:"></asp:Label>
            <asp:Label ID="MonthyInsurance" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p class="auto-style5">
            <asp:Label ID="Label18" runat="server" Font-Bold="False" ForeColor="Black" Text="MonthlyPrincipalAndInterest:"></asp:Label>
            <asp:Label ID="MontylyPrincipalAndInterest" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p class="auto-style5">
            <asp:Label ID="Label10" runat="server" Font-Bold="False" ForeColor="Black" Text="TotalPayment(include tax and insurance):"></asp:Label>
            <asp:Label ID="TotalPayment" runat="server" Font-Bold="True"></asp:Label>
        </p>
    
    </div>
        <p class="auto-style5">
            <strong><span class="auto-style8">Remote Service(StoreLocator):</span></strong></p>
        <p class="auto-style9">
            the link of discovered service introduction 
            <a href="ServiceIntroduction.html">link</a>

        </p>
        <p>
            <asp:Label ID="Label19" runat="server" style="color: #CC3300; font-weight: 700" Text="Input Zipcode(e.g. 85281)"></asp:Label>
            <asp:TextBox ID="ZipcodeText" runat="server" OnTextChanged="ZipcodeText_TextChanged"></asp:TextBox>
            <asp:Label ID="Label20" runat="server" style="color: #CC3300; font-weight: 700" Text="Input Store name(e.g. walmart , fry's food ...)"></asp:Label>
            <asp:TextBox ID="StoreText" runat="server"></asp:TextBox>
            <asp:Button ID="Search" runat="server" OnClick="Search_Click" Text="Search!" />
        </p>
        <p>
            Message about the nearest store:</p>
        <p>
            <asp:TextBox ID="result1" runat="server" Height="40px" Width="1002px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
