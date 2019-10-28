<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBookUi.aspx.cs" Inherits="BookInformationManagement.AddBookUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset name="Add Book" runat="server">
        <div class="form-group">
            <label for="inputBookName">Name</label>
            <input type="text" class="form-control" id="inputBookName" runat="server" placeholder="Enter Book Name" />
        </div>

        <div class="form-group">
            <label for="inputISBN">ISBN</label>
            <input type="text" class="form-control" id="inputISBN" runat="server" placeholder="Enter ISBN" />
        </div>

        <div class="form-group">
            <label for="inputAuthor">Author</label>
            <input type="text" class="form-control" id="inputAuthor" runat="server" placeholder="Enter Author Name" />
        </div>

        <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click"  />
        <br />
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    </fieldset>

</asp:Content>
