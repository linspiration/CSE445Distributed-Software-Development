<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login"  %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>
    
        <h2><span class="auto-style3">Welcome to Tool Box System,this is user login page</span></h2>
    
    <section id="loginForm">
        <asp:Login ID="Login1" runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
            <LayoutTemplate>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                <fieldset>
                    <legend>Log in Form</legend>
                    <ol>
                        <li>
                            <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName">User name</asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                        </li>
                        <li>
                            <asp:Label ID="Label2" runat="server" AssociatedControlID="Password">Password</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="The password field is required." />
                        </li>
                        <li>
                            <asp:CheckBox runat="server" ID="RememberMe" />
                            <asp:Label ID="Label3" runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">Remember me?</asp:Label>
                        </li>
                    </ol>
                    <asp:Button ID="Button1" runat="server" CommandName="Login" Text="Log in" OnClick="Unnamed6_Click" />
                </fieldset>
            </LayoutTemplate>
        </asp:Login>
        <p class="auto-style2">
            <strong>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" CssClass="auto-style1">Register</asp:HyperLink>
            <span class="auto-style1">if you don't have an account.
        </span></strong>
        </p>
    </section>

    <section id="socialLoginForm">
        <h2>&nbsp;</h2>
    </section>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1
        {
            color: #FF0000;
        }
        .auto-style2
        {
            font-size: large;
        }
        .auto-style3
        {
            color: #0000FF;
        }
    </style>
</asp:Content>

