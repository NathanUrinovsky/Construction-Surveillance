<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChangePasswordWebForm.aspx.cs" Inherits="SupervisorClientUI.ChangePasswordWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <div class="white-color change-password-container">
        <div class="center">
            <h1>Change Password</h1>
        </div>
            <div class="input-container">
                <asp:Label ID="oldPasswordTitle" runat="server" Text="Old password:" Font-Size="18px"></asp:Label>
                <asp:TextBox ID="oldPasswordTextBox" runat="server"></asp:TextBox>
            </div>
            <div class="input-container">
                 <asp:Label ID="newPasswordTitle" runat="server" Text="New password:" Font-Size="18px"></asp:Label>
                 <asp:TextBox ID="newPasswordTextBox" runat="server"></asp:TextBox>
            </div>
            <div class="button-container">
                <asp:Button ID="changePasswordButton" runat="server" Text="Change password" OnClick="changePasswordButton_Click" CssClass="change-password-button"/>
            </div>
        <div>
            <br />
            <br />
            <asp:Label ID="changePasswordStatusLabel" runat="server" Text="could not change your password. one or more of the details you filled is incorrect"></asp:Label>
        </div>
    </div>
</asp:Content>
