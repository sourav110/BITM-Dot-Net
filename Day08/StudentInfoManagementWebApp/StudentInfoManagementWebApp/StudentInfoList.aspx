<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoList.aspx.cs" Inherits="StudentInfoManagementWebApp.StudentInfoList" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            width: 548px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Student Information Management App</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right">First Name: </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="firstNameTextBox" runat="server" Width="215px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Last Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="lastNameTextBox" runat="server" Width="215px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Username:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="userNameTextBox" runat="server" Width="215px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Registration no:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="regNoTextBox" runat="server" Width="215px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Email:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="emailTextBox" runat="server" Width="215px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Age:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="ageTextBox" runat="server" Width="215px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="messageLabel" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                
                <tr>
                    <td style="text-align: right">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ListBox ID="studentListBox" runat="server" Height="317px" Width="215px"></asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
