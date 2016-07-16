<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            font-size: x-large;
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Welcome to the Entrance of Tool Box System !</strong></div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="User Login" />
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Admin Login" />
        </p>
    </form>
</body>
</html>
