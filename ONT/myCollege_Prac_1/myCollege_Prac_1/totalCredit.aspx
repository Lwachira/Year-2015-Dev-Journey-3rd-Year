<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="totalCredit.aspx.cs" Inherits="myCollege_Prac_1.totalCredit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Total Credits per student</h1>

    <div class="form-group">
       <label for="txtStudentNum" id="lblstudentNum">Student Number</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtStudentNum"/>
        <br />

        <asp:DropDownList ID="ddlStudent" runat="server" CssClass="form-control" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="ddlStudent_SelectedIndexChanged" OnTextChanged="ddlStudent_TextChanged">

        </asp:DropDownList>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Search" CssClass="btn btn-danger" OnClick="btnSubmit_Click" />
    </div>

  
    <asp:GridView runat="server" ID="dgvCredits" CssClass="table">

    </asp:GridView>
   
</asp:Content>
