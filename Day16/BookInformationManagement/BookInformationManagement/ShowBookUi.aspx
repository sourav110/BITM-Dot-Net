<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowBookUi.aspx.cs" Inherits="BookInformationManagement.ShowBookUi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <label for="inputSearchBook">Name</label>
        <input type="text" class="form-control" id="inputSearchBook" runat="server" placeholder="Enter Book Name" />
    </div>
    <asp:Button ID="searchButton" class="btn btn-success" runat="server" Text="Search" OnClick="searchButton_Click"  />
    <br />
    <br />
    <asp:GridView ID="BookGridView" runat="server" AutoGenerateColumns ="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="SL No.">
                <ItemTemplate>
                    <%#Eval("BookId") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="ISBN">
                <ItemTemplate>
                    <%#Eval("ISBN") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <%#Eval("BookName") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Author">
                <ItemTemplate>
                    <%#Eval("Author") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

</asp:Content>
