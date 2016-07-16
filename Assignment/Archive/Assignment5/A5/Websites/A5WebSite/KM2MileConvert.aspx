<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KM2MileConvert.aspx.cs" Inherits="KM2MileConvert" %>

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
            <span class="auto-style1"><strong>Enjoying use KM&amp;Mile convert tool!</strong></span><br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            km&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            mile&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Transfer" />
            <br />
        </div>
        <p>
            &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            mile&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            km&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Transfer" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
