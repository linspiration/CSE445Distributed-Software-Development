<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tryItStemming.aspx.cs" Inherits="tryItWeatherForecast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            color: #CC3300;
        }
    </style>
</head>
<body style="font-size: x-large">
    <form id="form1" runat="server">
    <div>
    
        <strong><br />
        </strong>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Black" Text="Stemming Service:Analyze a string of words and replace the inflected or derived words to their stem or root word"></asp:Label>
        <br />
    
    </div>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style1" Text="Operation: string Stemming(string str);"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" CssClass="auto-style1" Text=" Input: A string ; Output: A string the inflected or derived words replaced by their stem word"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" BackColor="White" ForeColor="Black" Text="Input words(For example:enlighten passionate):"></asp:Label>
        <asp:TextBox ID="StemInput" runat="server"></asp:TextBox>
        <asp:Button ID="StemBtn" runat="server" OnClick="StemBtn_Click" Text="Invoke" />
        <br />
        <asp:Label ID="Label6" runat="server" BackColor="White" style="color: #0000FF" Text="Result:"></asp:Label>
        <asp:Label ID="StemResult" runat="server"></asp:Label>
    </form>
</body>
</html>
