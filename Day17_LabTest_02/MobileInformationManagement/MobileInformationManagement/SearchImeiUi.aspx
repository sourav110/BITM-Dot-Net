<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchImeiUi.aspx.cs" Inherits="MobileInformationManagement.SearchImeiUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="inputIMEI">IMEI</label>
        <input type="text" class="form-control" id="inputIMEI" runat="server" placeholder="Enter IMEI" />
    </div>
    <asp:Button ID="searchButton" class="btn btn-success" runat="server" Text="Search" OnClick="searchButton_Click" />
    <br />

    <div class="form-group">
        <label>Model Name</label>
    </div>
    <asp:Label ID="modelNameLabel" runat="server"></asp:Label>
    <br />

    <div class="form-group">
        <label>IMEI</label>
    </div>
    <asp:Label ID="imeiLabel" runat="server"></asp:Label>
    <br />

    <div class="form-group">
        <label>Price</label>
    </div>
    <asp:Label ID="priceLabel" runat="server"></asp:Label>

    <asp:Label ID="messageLabel" runat="server"></asp:Label>
</asp:Content>
