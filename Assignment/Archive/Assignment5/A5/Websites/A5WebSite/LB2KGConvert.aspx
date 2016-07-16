<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LB2KGConvert.aspx.cs" Inherits="LB2KBConvert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            color: #FF0000;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style1"><strong>Enjoy using lb-kg convert tool!</strong></span><br />
        <br />
&nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial" Text="Input the value and choose convert way:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="150px"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Names="Arial">
            <asp:ListItem>LBs To KG</asp:ListItem>
            <asp:ListItem>KG To LBs</asp:ListItem>
        </asp:RadioButtonList>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert" />
    
    </div>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" Text="Result Output:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
