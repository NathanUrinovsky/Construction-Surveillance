<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProfileWebForm.aspx.cs" Inherits="SupervisorClientUI.ProfileWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <div class="black-color">
        <h1>Profile</h1>
        <div class="profile-container">
            <div class="big-titles-profile-container">
                <asp:Label ID="nameTitle" runat="server" Text="Name:" Font-Size="45px"></asp:Label>
                <asp:Label ID="nameLabel" runat="server" Text="Label" Font-Size="35px"></asp:Label>
                <asp:Label ID="emailTitle" runat="server" Text="Email:" Font-Size="45px"></asp:Label>
                <asp:Label ID="emailLabel" runat="server" Text="Label" Font-Size="35px"></asp:Label>
            </div>
            <div style="font-size: 25px">
                <asp:Label ID="idLabel" runat="server" Text="ID: "></asp:Label>
                <asp:Label ID="idValueLabel" runat="server" Text="10 "></asp:Label>
                <asp:Label ID="statusLabel" runat="server" Text="| Status: "></asp:Label>
                <asp:Label ID="statusValueLabel" runat="server" Text="| Active "></asp:Label>
                <asp:Label ID="supervisorNameLabel" runat="server" Text=" | Supervisor: "></asp:Label>
                <asp:Label ID="supervisorNameValueLabel" runat="server" Text=" "></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>


