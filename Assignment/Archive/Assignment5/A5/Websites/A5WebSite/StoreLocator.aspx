<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StoreLocator.aspx.cs" Inherits="StoreLoactor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2
        {
            color: #0000FF;
        }
        .auto-style3
        {
            color: #000000;
        }
        .auto-style5
        {
            color: #FF0000;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style5">
            <strong>Enjoy using store locator </strong>
        </div>
        <p class="auto-style2">
            <strong>Store locator service:</strong><span class="auto-style3">Find the Nearest Store within 20 miles</span>&nbsp;&nbsp;
        </p>
        <p class="auto-style2">
            <strong>The link of discovered service introduction</strong></p>
            <a href="ServiceIntroduction.html">link</a>
        <p>
            <asp:Label ID="Label1" runat="server" style="color: #CC3300; font-weight: 700" Text="Input Zipcode(e.g. 85281)"></asp:Label>
            <asp:TextBox ID="ZipcodeText" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" style="color: #CC3300; font-weight: 700" Text="Input Store name(e.g. walmart , fry's food ...)"></asp:Label>
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
