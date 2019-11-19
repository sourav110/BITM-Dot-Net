<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentInfoUI.aspx.cs" Inherits="StudentInfoManagementApp.StudentInfoUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Student Info Management Application</h2>
    <div class="form-group">
        <label for="inputStudentName">Student Name</label>
        <input type="text" class="form-control" id="inputStudentName" runat="server" placeholder="Enter Name">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name can't be empty" ControlToValidate="inputStudentName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
        <label for="inputRegNo">Reg No</label>
        <input type="text" class="form-control" id="inputRegNo" runat="server" placeholder="Enter Reg No">
    </div>

    <div class="form-group">
        <label for="inputEmail">Email</label>
        <input type="text" class="form-control" id="inputEmail" runat="server" placeholder="Enter Email">
    </div>

    <div class="form-group">
        <label for="inputMobile">Mobile</label>
        <input type="text" class="form-control" id="inputMobile" runat="server" placeholder="Enter Mobile">
    </div>

    <div class="form-group">
        <label for="inputAge">Age</label>
        <input type="text" class="form-control" id="inputAge" runat="server" placeholder="Enter Age">
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Age must be in Integer" ControlToValidate="inputAge" Operator="DataTypeCheck" Type="Integer" ForeColor="Red"></asp:CompareValidator>
    </div>

    <div class="form-group">
        <label for="inputAddress">Address</label>
        <input type="text" class="form-control" id="inputAddress" runat="server" placeholder="Enter Address">
    </div>
    <asp:Button class="btn btn-primary" ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
    <br />
    <asp:Label ID="messageLabel" runat="server"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="StudentGridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                    <%#Eval("StudentName") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <Columns>
            <asp:TemplateField HeaderText="Reg No">
                <ItemTemplate>
                    <%#Eval("RegNo") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <Columns>
            <asp:TemplateField HeaderText="Email">
                <ItemTemplate>
                    <%#Eval("Email") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <Columns>
            <asp:TemplateField HeaderText="Mobile No">
                <ItemTemplate>
                    <%#Eval("MobileNo") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <Columns>
            <asp:TemplateField HeaderText="Age">
                <ItemTemplate>
                    <%#Eval("Age") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <Columns>
            <asp:TemplateField HeaderText="Address">
                <ItemTemplate>
                    <%#Eval("Address") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    <br />
</asp:Content>
