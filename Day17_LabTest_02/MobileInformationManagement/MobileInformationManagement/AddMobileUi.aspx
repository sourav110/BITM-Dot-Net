<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddMobileUi.aspx.cs" Inherits="MobileInformationManagement.AddMobileUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset name="Add Mobile" runat="server">
        <div class="form-group">
            <label for="inputModelName">Model Name</label>
            <input type="text" class="form-control" id="inputModelName" runat="server" placeholder="Enter Mobile Model" />
        </div>

        <div class="form-group">
            <label for="inputIMEI">IMEI</label>
            <input type="text" class="form-control" id="inputIMEI" runat="server" placeholder="Enter IMEI" />
        </div>

        <div class="form-group">
            <label for="inputPrice">Price</label>
            <input type="text" class="form-control" id="inputPrice" runat="server" placeholder="Enter Price" />
        </div>

        <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />
        <br />
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    </fieldset>

</asp:Content>
