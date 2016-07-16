<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TryIt.aspx.cs" Inherits="TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 style="color: rgb(204, 51, 0); font-family: Times; font-style: normal; font-variant: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px;">Test Client of Stemming and Weather Service</h2>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Localhost URL :http://localhost:50237/Service.svc?wsdl" ForeColor="Blue"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="(1)Stemming Service:Analyze a string of words and replace the inflected or derived words to their stem or root word" Font-Bold="True" Font-Size="Larger" ForeColor="Black"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label3" runat="server" Text="Operation: string Stemming(string str);" ForeColor="Blue"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text=" Input: A string ; Output: A string the inflected or derived words replaced by their stem word" ForeColor="Blue"></asp:Label>
        </p>
        <asp:Label ID="Label5" runat="server" BackColor="White" ForeColor="Black" Text="Input words:(For example:enlighten passionate)"></asp:Label>
        <asp:TextBox ID="StemInput" runat="server"></asp:TextBox>
        <asp:Button ID="StemBtn" runat="server" OnClick="StemBtn_Click" Text="Invoke" />
        <p>
            <asp:Label ID="Label6" runat="server" BackColor="White" Text="Result:"></asp:Label>
            <asp:Label ID="StemResult" runat="server"></asp:Label>
        </p>
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Larger" Text="(2)Weather Service:Create a 5-day weather forecast service of zipcode location " ForeColor="Black"></asp:Label>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Operation: string[] Weather5day(string zipcode)"></asp:Label>
        </p>
        <asp:Label ID="Label9" runat="server" Text="Input: a U.S. zipcode ; Output: An array (or list) of strings, storing 5-day weather forecast for the given zipcode location." ForeColor="Blue"></asp:Label>
        <p>
            <asp:Label ID="Label10" runat="server" Text="Input zipcode:(For exampe:85281)" ForeColor="Blue"></asp:Label>
            <asp:TextBox ID="WeatherInput" runat="server" Width="248px"></asp:TextBox>
            <asp:Button ID="WeahterBtn" runat="server" OnClick="WeahterBtn_Click" Text="Invoke" />
        </p>
        <asp:Label ID="Label11" runat="server" Text="Result:"></asp:Label>
        <p>
            <asp:Label ID="WeatherResult1" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="WeatherResult2" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="WeatherResult3" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="WeatherResult4" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="WeatherResult5" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
