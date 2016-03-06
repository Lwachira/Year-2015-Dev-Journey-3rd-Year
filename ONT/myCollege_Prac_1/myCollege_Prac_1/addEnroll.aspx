<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addEnroll.aspx.cs" Inherits="myCollege_Prac_1.addEnroll" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 >Enroll Add/View</h1>

    <div class="form-group">
        <label for="txtClassCode" id="lblClassCode">Class Code</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtClassCode"/>

        <label for="txtStudentNum" id="lblStudentNumber">Student Number</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtStudentNumber" />

        <label for="txtGrade" id="lblGrade">Enroll Grade</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtGrade" />

        <br />
        <asp:Button Text="Send" CssClass="btn btn-default" runat="server"  ID="btnSend" OnClick="btnSend_Click"/>
    </div>
    <br />

    <asp:GridView ID="table" runat="server" CssClass="table">

    </asp:GridView>

</asp:Content>
