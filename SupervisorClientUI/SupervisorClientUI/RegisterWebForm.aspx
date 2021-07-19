<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterWebForm.aspx.cs" Inherits="SupervisorClientUI.RegisterWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="align-to-center">
            <div>
                <h1>Create an account</h1>
            </div>
            <div class="align-content-to-left register-container">
           
                <div class="input-container">
                    <div>
                        <asp:Label ID="usernameLabel" runat="server" Text="Username:"></asp:Label>
                        <asp:RequiredFieldValidator ID="userNameRequiredValidator" runat="server" ErrorMessage="Required field" ControlToValidate="usernameTextBox"></asp:RequiredFieldValidator>
                    </div>
                    <div>
                        <asp:TextBox ID="usernameTextBox" runat="server" CssClass="width"></asp:TextBox>
                    </div>
                </div>
                <div class="input-container">
                    <div>
                        <asp:Label ID="passwordLabel" runat="server" Text="Password:"></asp:Label>
                        <asp:RequiredFieldValidator ID="passwordRequiredValidator" runat="server" ErrorMessage="Required field" ControlToValidate="passwordTextBox"></asp:RequiredFieldValidator>
                    </div>
                    <div>
                        <asp:TextBox ID="passwordTextBox" runat="server" CssClass="width"></asp:TextBox>
                    </div>
                </div>
                <div class="input-container">
                    <div>
                        <asp:Label ID="emailLabel" runat="server" Text="Email:"></asp:Label>
                        <asp:RequiredFieldValidator ID="emailRequired" runat="server" ErrorMessage="Required field" ControlToValidate="emailTextBox"></asp:RequiredFieldValidator>
                    
                        <asp:RegularExpressionValidator ID="emailOrderValidator" runat="server" ControlToValidate="emailTextBox" ErrorMessage="email isn't in the correct format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </div>
                    <div>
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="input-container">
                    <div>
                        <asp:Label ID="Name" runat="server" Text="Name:"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required field" ControlToValidate="empNameTextBox"></asp:RequiredFieldValidator>
                    </div>
                    <asp:TextBox ID="empNameTextBox" runat="server"></asp:TextBox>    
                </div>
                <div class="button-container">
                    <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" CssClass="login-button"/>
                    <asp:Button ID="backToLoginButton" runat="server" Text="Back To Login without registration" OnClick="backToLoginButton_Click" CssClass="login-button" CausesValidation="false"/>
                </div>
                <div class="user-error-msg align-to-center">
                    <asp:Label ID="registrationStatusLabel" runat="server" Text="There was an error creating your account"></asp:Label>
                </div>
            </div>
        </div>
     
    </form>
</body>
</html>
