<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportDetailsWebForm.aspx.cs" Inherits="SupervisorClientUI.ReportDetailsWebForm" %>
<script src="Script.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="report-details-container">
            <div>
                <h1>Report Details</h1>
            </div>
            <div class="left-right-container">
                    <div class="left">
                    <asp:Label ID="fromTitle" runat="server" Text="From: "></asp:Label>
                    <asp:Label ID="subjectTitle" runat="server" Text="Subject: "></asp:Label>
                </div>

                <div class="right">
                   <asp:Label ID="fromInput" runat="server" Text=""></asp:Label>
                   <asp:Label ID="subjectInput" runat="server" Text=""></asp:Label>
                </div>
           </div>
            <div>
                <asp:Label ID="contentTitle" runat="server" Text="Content:"></asp:Label>
            </div>
            <div></div>
            <asp:TextBox ID="contentTextBox" runat="server" TextMode="MultiLine" ReadOnly="True" Width="70%" Font-Names="Arial" Font-Size="Medium" style="resize:none;"></asp:TextBox>
            <div class="controls-report-details-container">
                <asp:ListBox ID="fileListBox" runat="server" OnSelectedIndexChanged="fileListBox_SelectedIndexChanged"></asp:ListBox>
                <asp:Button ID="showFileButton" runat="server" Text="View selected file" OnClick="showFileButton_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
