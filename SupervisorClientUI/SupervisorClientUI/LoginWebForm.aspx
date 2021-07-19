<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWebForm.aspx.cs" Inherits="SupervisorClientUI.LoginWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <script src="Scripts.js"></script>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="absolute align-to-center">
            <div class="font-color">
                <h1>Login</h1>
            </div>
            <div class="login-container align-content-to-left">
                <div class="login-input-container">
                    <div>
                        <asp:Label ID="usernameLabel" runat="server" Text="Username:"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="login-input-container">
                    <div>
                        <asp:Label ID="passwordLabel" runat="server" Text="Password:"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="passwordTextBox" runat="server" CssClass="square-text"></asp:TextBox>
                    </div>
                </div>
                <div class="button-container">
                    <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" CssClass="login-button"/>
                </div>
                <div class="button-container">
                    <asp:Button ID="toRegisterButton" runat="server" Text="Register" OnClick="toRegisterButton_Click" CssClass="login-button"/>
                </div>
                <div class="user-error-msg align-to-center">
                    <asp:Label ID="loginSucceededLabel" runat="server" Text="Invalid username or password"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
