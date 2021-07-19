<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AllReportsWebForm.aspx.cs" Inherits="SupervisorClientUI.AllReportsWebForm" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <div class="black-color">
        <h1>My Reports</h1>
        <div class="report-panel-container">
            <asp:Panel ID="reportsPanel" runat="server" BorderColor="white" Height="650px" BorderStyle="Solid" ScrollBars="Vertical">
            <div class="report-gridview-container">
                <asp:GridView ID="reportsGridView" runat="server" OnRowDataBound="reportsGridView_RowDataBound" OnSelectedIndexChanged="reportsGridView_SelectedIndexChanged" AutoGenerateColumns="True" CssClass="reports-table" BorderStyle="Outset" RowStyle-CssClass="GridView"></asp:GridView>
            </div>
        </asp:Panel>
        </div>
    </div>
</asp:Content>
