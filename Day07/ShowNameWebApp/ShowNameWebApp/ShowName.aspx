<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowName.aspx.cs" Inherits="ShowNameWebApp.ShowName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Name "></asp:Label>
&nbsp;<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text="Your Name is: "></asp:Label>
            <asp:Label ID="showLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
