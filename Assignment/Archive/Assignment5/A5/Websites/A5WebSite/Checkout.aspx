<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            font-size: large;
            color: #FF0000;
        }
        .auto-style2
        {
            color: #0000FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Check out successfully!!!<br />
        <span class="auto-style2">You can click the link to use the tool you purchased:</span></strong></div>
         <asp:ListBox ID="ListBox1" runat="server" Height="300px" Width="1253px"></asp:ListBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Use this tool!" />
        </p>
    </form>
</body>
</html>
