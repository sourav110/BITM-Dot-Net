<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankAccountApp.aspx.cs" Inherits="BankAccountTransactionWebApp.BankAccountApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 10px;
        }
        .auto-style2 {
            margin-left: 21px;
        }
        .auto-style3 {
            margin-left: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" GroupingText="Account Creation" Height="110px" Width="344px">
                <asp:Label ID="accountNoLabel" runat="server" Text="Account Number"></asp:Label>
                &nbsp;<asp:TextBox ID="accountNoTextBox" runat="server" Width="166px"></asp:TextBox>
                <br />
                <asp:Label ID="customerNameLabel" runat="server" Text="Customer Name"></asp:Label>
                <asp:TextBox ID="customerNameTextBox" runat="server" CssClass="auto-style1" Width="165px"></asp:TextBox>
                <br />
                <asp:Button ID="createButton" runat="server" Text="Create" Width="73px" OnClick="createButton_Click" />
                <br />
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" GroupingText="Transaction" Width="352px" Height="136px">
                <asp:Label ID="amountLabel" runat="server" Text="Amount"></asp:Label>
                &nbsp;<asp:TextBox ID="amountTextBox" runat="server" CssClass="auto-style2" Width="158px"></asp:TextBox>
                <br />
                <asp:Button ID="depositButton" runat="server" Text="Deposit" OnClick="depositButton_Click" />
                <asp:Button ID="withdrawButton" runat="server" Text="Withdraw" CssClass="auto-style3" Width="79px" OnClick="withdrawButton_Click" />
                <br />
                <asp:Button ID="showReportButton" runat="server" Text="Show Report" Width="258px" OnClick="showReportButton_Click" />
                <br />
                <asp:Label ID="reportLabel" runat="server"></asp:Label>
                <br />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
