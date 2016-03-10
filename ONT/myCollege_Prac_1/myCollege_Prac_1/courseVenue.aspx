<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="courseVenue.aspx.cs" Inherits="myCollege_Prac_1.courseVenue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Course Venue</h1>


    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <asp:Button ID="btnSubmit" runat="server" Text="Button" CssClass="btn btn-danger" />

     <asp:GridView ID="table" runat="server" CssClass="table">

    </asp:GridView>
</asp:Content>

