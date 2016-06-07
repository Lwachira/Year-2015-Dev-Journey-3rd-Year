<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllShipper.aspx.cs" Inherits="examNorthwind.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>View All Shipper</h1>
    <asp:GridView ID="dgvShipper" runat="server" CssClass="table"></asp:GridView>
</asp:Content>
