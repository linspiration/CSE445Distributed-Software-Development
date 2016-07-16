<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tryItStoreLocator.aspx.cs" Inherits="tryIt" %>

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
            color: #000000;
        }
        .auto-style4
        {
            color: #CC3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style1"><strong>We</strong></span><strong><span class="auto-style1">lcome to the test client of store locator service(Challenging Service)!</span></strong></div>
        <p class="auto-style4">
            <strong>This service is Restful serive,you can also test the operation in the following URIs:</strong></p>
        <p class="auto-style4">

            http://webstrar21.fulton.asu.edu/page0/page01/Service.svc/input?zipcode=85281&amp;storeName=walmart<p class="auto-style4">

        <p class="auto-style2">
            <strong>Store locator service:</strong><span class="auto-style3">Find the Nearest Store within 20 miles</span><strong>.</strong></p>
        <p>
            <span class="auto-style2"><strong>Operation</strong></span>: string findNearestStore(string zipcode, string storeName);<span class="auto-style2"> <strong>Input</strong></span>: two strings,zipcode and storename <span class="auto-style2"><strong>Output</strong></span>: string message</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Input Zipcode(e.g. 85281)" style="color: #CC3300; font-weight: 700"></asp:Label>
            <asp:TextBox ID="ZipcodeText" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Input Store name(e.g. walmart , fry's food ...)" style="color: #CC3300; font-weight: 700"></asp:Label>
            <asp:TextBox ID="StoreText" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search!" />
        </p>
        <p>
            Message about the nearest store:</p>
        <p>
        <asp:TextBox ID="result1" runat="server" Height="46px" Width="1002px"></asp:TextBox>
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
