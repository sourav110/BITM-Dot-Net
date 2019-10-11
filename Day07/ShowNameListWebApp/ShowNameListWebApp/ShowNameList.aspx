<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowNameList.aspx.cs" Inherits="ShowNameListWebApp.ShowNameList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Name: "></asp:Label>
&nbsp;<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
            <asp:Button ID="showAllButton2" runat="server" Text="Show All" OnClick="showAllButton2_Click" />
            <br />
            <asp:ListBox ID="showListBox" runat="server" Height="121px" Width="167px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
