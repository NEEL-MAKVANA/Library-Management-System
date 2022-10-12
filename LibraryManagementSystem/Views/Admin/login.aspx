<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LibraryManagementSystem.Views.Admin.login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            color: #0066FF;
            width: 1311px;
            height: 43px;
        }
        .auto-style2 {
            width: 99%;
            height: 150px;
        }
        .auto-style3 {
            width: 540px;
        }
        .auto-style8 {
            font-size: large;
        }
        .auto-style15 {
            width: 540px;
            height: 50px;
            font-size: x-large;
            text-align: right;
        }
        .auto-style16 {
            height: 50px;
        }
        .auto-style17 {
            text-align: left;
        }
        .auto-style18 {
            height: 249px;
            width: 1313px;
        }
        .auto-style19 {
            text-align: center;
            width: 1313px;
            height: 42px;
        }
        .auto-style20 {
            font-size: x-large;
        }
        .auto-style21 {
            width: 540px;
            height: 46px;
            font-size: x-large;
            text-align: right;
        }
        .auto-style22 {
            height: 46px;
        }
    </style>
</head>
<body style="width: 1384px; height: 256px; margin-right: 176px">

    <form id="form1" runat="server" class="auto-style18">
        <p class="auto-style1">
            <strong>Login Form</strong></p>
        <table class="auto-style2">
            <tr>
                <td class="auto-style21"><span class="auto-style8">Username</span> :&nbsp;&nbsp; </td>
                <td class="auto-style22">
                    <asp:TextBox ID="textBoxUsername" runat="server" CssClass="auto-style8" Height="30px" Width="302px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15"><span class="auto-style8">Password</span> :&nbsp;&nbsp; </td>
                <td class="auto-style16">
                    <asp:TextBox ID="textBoxPassword" TextMode="Password" runat="server" CssClass="auto-style8" Height="30px" Width="301px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style17">
                    <asp:Button ID="btnLogin" runat="server" CssClass="auto-style8" Height="36px" Text="Login" Width="109px" OnClick="loginClick" />
                </td>
            </tr>
        </table>
        <div class="auto-style19">
            <asp:Label ID="msg" runat="server" CssClass="auto-style20" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>

</body>
</html>