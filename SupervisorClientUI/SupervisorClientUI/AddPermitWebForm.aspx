<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddPermitWebForm.aspx.cs" Inherits="SupervisorClientUI.AddPermitWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <div class="white-color">
        <div>
            <h1>Add a permit</h1>
        </div>
        <div class="add-permit-container">
            <asp:Label ID="addressTitle" runat="server" Text="Pick an address:"></asp:Label>
                <asp:DropDownList ID="addressDropDown" runat="server" OnSelectedIndexChanged="addressDropDown_SelectedIndexChanged"></asp:DropDownList>
            <div class="input-container">
                <asp:Label ID="permit" runat="server" Text="Permit description:" Font-Size="20px"></asp:Label>
                <div>
                    <asp:TextBox ID="permitNameValueTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
        </div>
        <div>
            <asp:Button ID="addPermitButton" runat="server" Text="Add Permit" OnClick="addPermitButton_Click"  AutoPostback="false" CausesValidation="false" CssClass="button-in-permit"/>
            <asp:Button ID="clearingButton" runat="server" Text="Clear" OnClick="clearingButton_Click" CssClass="button-in-permit"/>
        </div>
        <div style="font-size: 18px">
            <asp:Label ID="addingPermitSuccessLabel" runat="server" Text=" "></asp:Label>
        </div>
    </div>
</asp:Content>

