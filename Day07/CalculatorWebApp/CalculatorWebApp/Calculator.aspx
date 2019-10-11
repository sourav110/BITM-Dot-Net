<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="CalculatorWebApp.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Unit Price: "></asp:Label>
            <asp:TextBox ID="unitPriceTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Total Quantity: "></asp:Label>
            <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="calculateButton" runat="server" Text="Calculate" OnClick="calculateButton_Click" />
            &nbsp;<asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Total Price: "></asp:Label>
            <asp:TextBox ID="totalPriceTextBox" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
