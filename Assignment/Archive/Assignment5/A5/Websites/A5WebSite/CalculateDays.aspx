<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalculateDays.aspx.cs" Inherits="CalculateDays" %>

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
    <span class="auto-style1"><strong>Enjoy using days calculate tool!</strong></span><form id="form1" runat="server">
        <br />
        <asp:Label ID="Label6" runat="server" Font-Names="Arial" Text="Operation: int GetDayBetweenTwoDates(string date1, string date2)"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Font-Names="Arial" Text="Input: The two dates in the form of &quot;20131030&quot;"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Font-Names="Arial" Text="Output: The days between these two dates"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Arial" Text="Input the earlier dates:(eg. 20130830)"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Arial" Text="Input the later dates:(eg. 20131026)"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Calculate" />
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Names="Arial" Text="Output the day between two dates:"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <div>
    
    </div>
    </form>
</body>
</html>
