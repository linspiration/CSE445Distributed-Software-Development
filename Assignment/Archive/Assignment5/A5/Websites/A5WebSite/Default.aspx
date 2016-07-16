<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix = "time" TagName="CurrentTime" 
			src="CurrentTime.ascx" %>
<%@ Register TagPrefix = "date" TagName="CurrentDate" 
			src="CurrentDate.ascx" %>
<%@ Register TagPrefix = "season" TagName="CurrentSeason" 
			src="CurrentSeason.ascx" %>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <p class="auto-style2">
        <strong style="font-size: x-large">Welcome to the Home Page of Tool Box System!&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <span class="auto-style4"><a href="Account/Manage.aspx">Manage your account<asp:Button ID="adminBtn" runat="server" OnClick="Button4_Click1" Text="admin page(Only can be accessed by administrator)" Height="52px" Width="856px" />
        </a></span>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Log Off" Width="142px" />
        </p>
    <p class="auto-style1">
         <strong><span class="auto-style3">Login date</span>:<date:CurrentDate ID="CurrentDate1" runat = "server" />
         <span class="auto-style3">Login time</span>:</strong><time:CurrentTime ID="CurrentTime1" runat = "server" />
         <strong><span class="auto-style3">Login season</span>:</strong><season:CurrentSeason ID="CurrentSeason1" runat = "server" />
         &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
         <asp:ListBox ID="ListBox1" runat="server" Height="300px" Width="1253px"></asp:ListBox>
    </p>
    <p>
        <span class="auto-style3"><strong>tool name :
        <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
        </strong></span>
        <br />
        <span class="auto-style3"><strong>tool price:
        <asp:Label ID="Label2" runat="server" Text="price"></asp:Label>
        </strong></span>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add tool to shopping cart" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Tool Details" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Go to Shopping Cart" Width="342px" />
    </p>
    </asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1
        {
            color: #FF0000;
            font-weight: 700;
        }
        .auto-style2
        {
            color: #0000FF;
            font-weight: 700;
        }
        .auto-style3
        {
            color: #0000FF;
        }
        .auto-style4
        {
            font-size: small;
        }
    </style>
</asp:Content>
