<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HeightWeightEvaluation.aspx.cs" Inherits="HeightWeightEvaluation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            color: #FF0000;
            font-size: large;
        }
    </style>
</head>
<body>
    <p class="auto-style1">
        <strong>Enjoy using height_weight evaluation tool</strong></p>
    <p>
        <strong>Remote Service:</strong> Enter your height and weight information and get evaluation</p>
    <p>
        Enter Height(For example 170)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Weight(For example 65)</p>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            cm&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            kg&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Get Evaluation" />
        </p>
        <p>
            Evaluation</p>
        <p>
            <asp:TextBox ID="TextBox7" runat="server" Width="586px"></asp:TextBox>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
