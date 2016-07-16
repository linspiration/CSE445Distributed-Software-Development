<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tryItWeatherForecast.aspx.cs" Inherits="tryItWeatherForecast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            color: #CC3300;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Larger" Text="Weather Service:Create a 5-day weather forecast service of zipcode location " style="font-size: xx-large"></asp:Label>
    
        <br />
        <br />
    
    </div>
        <strong>
        <asp:Label ID="Label8" runat="server" CssClass="auto-style1" Text="Operation: string[] Weather5day(string zipcode)"></asp:Label>
        <br class="auto-style1" />
        <asp:Label ID="Label9" runat="server" CssClass="auto-style1" Text="Input: a U.S. zipcode ; Output: An array (or list) of strings, storing 5-day weather forecast for the given zipcode location."></asp:Label>
        </strong>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label10" runat="server" style="font-size: x-large" Text="Input zipcode(For exampe:85281):"></asp:Label>
        <asp:TextBox ID="WeatherInput" runat="server" Width="248px"></asp:TextBox>
        <asp:Button ID="WeahterBtn" runat="server" OnClick="WeahterBtn_Click" Text="Invoke" />
        <br />
        <asp:Label ID="Label11" runat="server" style="font-size: x-large; color: #0000FF" Text="Result:"></asp:Label>
        <br />
        <asp:Label ID="WeatherResult1" runat="server" style="font-size: x-large"></asp:Label>
        <br />
        <asp:Label ID="WeatherResult2" runat="server" style="font-size: x-large"></asp:Label>
        <br />
        <asp:Label ID="WeatherResult3" runat="server" style="font-size: x-large"></asp:Label>
        <br />
        <asp:Label ID="WeatherResult4" runat="server" style="font-size: x-large"></asp:Label>
        <br />
        <asp:Label ID="WeatherResult5" runat="server" style="font-size: x-large"></asp:Label>
    </form>
</body>
</html>
