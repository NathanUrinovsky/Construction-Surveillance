<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SendReportWebForm.aspx.cs" Inherits="SupervisorClientUI.SendReportWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <div class="send-mail-container">
        <h1>Send message</h1>
        <div class="align-content-to-left">
            <h3>To:</h3>
            <div class="input-container">
                <asp:TextBox ID="addresseeEmailTextBox" runat="server"></asp:TextBox>
            </div>
            <h3>Subject:</h3>
            <div class="input-container">
                <asp:TextBox ID="subjectTextBox" runat="server"></asp:TextBox>
            </div>
            <h3>Content:</h3>
            <div class="input-container">
                <asp:TextBox ID="contentTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="button-container">
                <div>
                    <asp:FileUpload ID="fileUpload" runat="server" AllowMultiple ="true"/>
                </div>
                <div>
                     <asp:Button ID="sendReportButton" runat="server" Text="Send mail" OnClick="sendReportButton_Click" CssClass="login-button"/>
                </div>
            </div>
        </div>
        <div>
            <asp:Label ID="successInSendingReportLabel" runat="server" Text=""></asp:Label>
        </div>
            
    </div>
</asp:Content>
