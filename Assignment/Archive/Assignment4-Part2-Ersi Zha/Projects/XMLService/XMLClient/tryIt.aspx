<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tryIt.aspx.cs" Inherits="XMLClient.tryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            font-size: x-large;
        }
        .auto-style2
        {
            font-size: large;
            color: #0000FF;
        }
        .auto-style3
        {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong><span class="auto-style3">Welcome to the Test Page!</span><br />
        <span class="auto-style2">1.Verification<br />
        Input URL of XML file:<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="1128px"></asp:TextBox>
        <br />
        Input URL of XSD file:<asp:TextBox ID="TextBox2" runat="server" Width="1204px"></asp:TextBox>
        </span></strong>
    
    </div>
        <asp:Button ID="VerifyBtn" runat="server" OnClick="Button1_Click" Text="Verify" />
        <asp:TextBox ID="Result1" runat="server" Width="892px" Height="116px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <span class="auto-style2"><strong>2.Search WSDL Operation Names<br />
        Input WSDL URL:</strong></span><asp:TextBox ID="TextBox3" runat="server" Width="930px"></asp:TextBox>
        <asp:Button ID="SearchBtn" runat="server" OnClick="SearchBtn_Click" Text="Search" />
        <asp:TextBox ID="Result2" runat="server" Width="652px"></asp:TextBox>
    </form>
</body>
</html>
