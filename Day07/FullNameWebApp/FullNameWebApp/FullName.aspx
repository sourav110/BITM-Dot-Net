<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FullName.aspx.cs" Inherits="FullNameWebApp.FullName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="First Name "></asp:Label>
            <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name "></asp:Label>
            <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Full Name "></asp:Label>
            <asp:TextBox ID="fullNameTextBox" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
