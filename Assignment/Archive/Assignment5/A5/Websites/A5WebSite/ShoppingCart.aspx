<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 339px">
    
        <asp:ListBox ID="ListBox1" runat="server" Height="160px" Width="324px"></asp:ListBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Continue shopping" />
    
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Checkout!" />
    
    </div>
    </form>
</body>
</html>
