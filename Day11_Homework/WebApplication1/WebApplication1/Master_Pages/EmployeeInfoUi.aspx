<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeInfoUi.aspx.cs" Inherits="WebApplication1.Master_Pages.EmployeeInfoUi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Information Management Application</h2>
    <h3>Employee Information</h3>

    <div class="form-group">
        <label for="inputEmployeeName">Name</label>
        <input type="text" class="form-control" id="inputEmployeeName" runat="server" placeholder="Enter Name">
    </div>

    <div class="form-group">
        <label for="inputEmployeeEmail">Email</label>
        <input type="text" class="form-control" id="inputEmployeeEmail" runat="server" placeholder="Enter Email">
    </div>

    <div class="form-group">
        <label for="input">Gender</label>
        <%--<div class="custom-control custom-radio custom-control-inline">
            <input type="radio" id="radioButtonMale" name="customRadioInline1" class="custom-control-input">
            <label class="custom-control-label" for="radioButtonMale">Male</label>
        </div>

        <div class="custom-control custom-radio custom-control-inline">
            <input type="radio" id="radioButtonFemale" name="customRadioInline1" class="custom-control-input">
            <label class="custom-control-label" for="radioButtonFemale">Female</label>
        </div>--%>

        <br />
        <asp:RadioButton ID="maleRadioButton" runat="server" GroupName="gender" Text=" Male" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;       
        <asp:RadioButton ID="femaleRadioButton" runat="server" GroupName="gender" Text=" Female" />

        <%--<asp:RadioButtonList ID="genderRadioButton" runat="server" RepeatLayout="Flow">
            <asp:RadioButton ID="maleRadioButton" runat="server" GroupName="gender" Text=" Male" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;       
        <asp:RadioButton ID="femaleRadioButton" runat="server" GroupName="gender" Text=" Female" />
        </asp:RadioButtonList>--%>

    </div>

    <div class="form-group">
        <label for="inputDoJ">Date Of Joining</label>
        <input type="text" class="form-control" id="inputDoJ" runat="server">
        <asp:ImageButton ID="calendarImageButton" runat="server" OnClick="calendarImageButton_Click" Width="16px" />
        <asp:Calendar ID="dateOfJoinCalendar" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="182px" NextPrevFormat="ShortMonth" Width="277px" OnSelectionChanged="dateOfJoinCalendar_SelectionChanged">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>

    </div>

    <div class="form-group">
        <label for="inputDesignation">Designation</label>
        <input type="text" class="form-control" id="inputDesignation" runat="server" placeholder="Enter Designation">
    </div>

    <div class="form-group">
        <label for="inputSalary">Salary</label>
        <input type="text" class="form-control" id="inputSalary" runat="server" placeholder="Enter Salary">
    </div>

    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
    <br />

    <asp:Label ID="messageLabel" runat="server" ></asp:Label>


</asp:Content>
