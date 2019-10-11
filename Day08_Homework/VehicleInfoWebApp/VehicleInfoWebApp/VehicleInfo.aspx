<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicleInfo.aspx.cs" Inherits="VehicleInfoWebApp.VehicleInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 485px;
        }
        .auto-style2 {
            text-align: right;
            width: 324px;
        }
        .auto-style3 {
            width: 324px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1"><strong>Vehicle Info Manager</strong></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right" class="auto-style3">Vehicle Name:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="nameTextBox" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right" class="auto-style3">Registration No:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="regNoTextBox" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="createButton" runat="server" Text="Create" Width="155px" OnClick="createButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right" class="auto-style3">Speed: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="speedTextBox" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="enterButton" runat="server" Text="Enter" Width="154px" OnClick="enterButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="showButton" runat="server" Text="Show" Width="154px" OnClick="showButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Max Speed:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="maxTextBox" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Min Speed:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="minTextBox" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Average Speed:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="avgTextBox" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Vehicle Detail:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="detailTextBox" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
