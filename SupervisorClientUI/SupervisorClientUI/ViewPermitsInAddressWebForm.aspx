<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewPermitsInAddressWebForm.aspx.cs" Inherits="SupervisorClientUI.ViewPermitsInAddressWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 >View permits</h1>
    <div class="permits-all-controls-container">
        <div class="view-permit-container">
            <asp:Label ID="addressTitle" runat="server" Text="Pick an address: "></asp:Label>
            <asp:DropDownList ID="addressDropdown" runat="server" OnSelectedIndexChanged="addressDropdown_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <div class="permits-panel-container">
            <asp:Panel ID="permitsPanel" runat="server" BorderColor="white" BorderStyle="Solid"  ScrollBars="Vertical" Height="650px" HorizontalAlign="Center">
                <div> 
                    <asp:GridView ID="permitGridView" runat="server"  CssClass="permit-view-table" OnRowDataBound="permitGridView_RowDataBound" EditRowStyle-Wrap="true" HorizontalAlign="Center"></asp:GridView>
                </div>
            </asp:Panel>
        </div>
        <div class="permits-button-container">
            <asp:Button ID="viewPermitsButton" runat="server" Text="View permits" OnClick="viewPermitsButton_Click" CssClass="login-button" Width="23.5%"/>
        </div>
    </div>
</asp:Content>
