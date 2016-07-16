<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TipCalculator.aspx.cs" Inherits="TipCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style1
        {
            font-size: x-large;
            color: #000000;
        }
        .auto-style2
        {
            color: #0000FF;
        }
        .auto-style3
        {
            color: #CC3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style1">Enjoying using Tip Calculator</span></strong></div>
        <p>
            <strong><span class="auto-style2">Tip calculation </span>:</strong>Calculate the tip payment information in restaurant.</p>
        <p class="auto-style3">
            <strong>Input information here(input numbers only):</strong></p>
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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate!" />
        </p>
        <p>
            &nbsp;</p>
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
    </form>
    
</body>
</html>
