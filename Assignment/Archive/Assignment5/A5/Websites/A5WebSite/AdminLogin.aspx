<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="Login" %>

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
        <span class="auto-style1"><strong>Admin login Page</strong></span><br />
        <br />
        Username<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <p>
            <asp:Label runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword"  runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="login" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Log off" />
        <p>
            <asp:Label ID="Output" runat="server"></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go to the home page of Tool Box System" />
        </p>
    </form>
</body>
</html>
<script language="C#" runat="server">
  void LoginFunc(Object sender, EventArgs e)
  {
      if (FormsAuthentication.Authenticate(txtUserName.Text,txtPassword.Text))
          FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
      else
         Output.Text = "Invalid login";
  }
</script>
