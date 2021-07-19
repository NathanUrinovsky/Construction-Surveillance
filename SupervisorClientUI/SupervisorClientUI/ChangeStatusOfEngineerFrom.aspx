<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChangeStatusOfEngineerFrom.aspx.cs" Inherits="SupervisorClientUI.ChangeStatusOfEngineerFrom"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="change-engineer-status-container black-color">
        <h1>Change engineer's status</h1>
        <asp:Label ID="dropdownTitle" runat="server" Text="Pick an email of one of your engineers:" Font-Size="18px"></asp:Label>
        <div>
            <asp:DropDownList ID="addressDropdown" runat="server" AutoPostBack="true" OnSelectedIndexChanged="addressDropdown_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <asp:Label ID="engineerDataTitle" runat="server" Text="Engineer details:"></asp:Label>
             
        <div class="panel-details-container">
            <asp:Panel ID="engineerDetailsPanel" runat="server" BorderStyle="Solid" Height="80px" BorderColor="White">
                <div class="engineer-details-container">
                    <div>
                        <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="emailLabel" runat="server" Text=""></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="statusLabel" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </asp:Panel>
        </div>
        <div>
            <asp:Button ID="viewEngineerDetails" runat="server" Text="View engineer details" OnClick="viewEngineerDetails_Click" CssClass="login-button"/>
            <asp:Button ID="changeEngineerStatusButton" runat="server" Text="Change Engineer Status" OnClick="changeEngineerStatusButton_Click" CssClass="login-button"/>
        </div>
        
        <asp:Label ID="succesLabel" runat="server" Text=" "></asp:Label>
    </div>
</asp:Content>
