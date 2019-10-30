<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowMobileUi.aspx.cs" Inherits="MobileInformationManagement.ShowMobileUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="inputLowerPrice">Price between</label>
        <input type="text" class="form-control" id="inputLowerPrice" runat="server" placeholder="Enter lower price" />
    </div>
    <%--<p>and</p>--%>
    <div class="form-group">
        <label for="inputHigherPrice">and</label>
        <input type="text" class="form-control" id="inputHigherPrice" runat="server" placeholder="Enter higher price" />
    </div>

    <asp:Button ID="searchButton" class="btn btn-success" runat="server" Text="Search" OnClick="searchButton_Click" />
    <br />
    <br />

    <asp:GridView ID="MobileGridView" runat="server" AutoGenerateColumns ="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="SL No.">
                <ItemTemplate>
                    <%#Eval("MobileId") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Model Name">
                <ItemTemplate>
                    <%#Eval("ModelName") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="IMEI">
                <ItemTemplate>
                    <%#Eval("IMEI") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Price">
                <ItemTemplate>
                    <%#Eval("Price") %>
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
