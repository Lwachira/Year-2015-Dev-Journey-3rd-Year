<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addCharter.aspx.cs" Inherits="Aviaco_V1.addCharter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Add New Charters</h1>

    <div class="form-group">
         <asp:Label   ID="lblDate" runat="server" Text="Date"></asp:Label>


        <input type="datetime-local" name="charterDate" class="form-control" runat="server"  />


<%--    <asp:TextBox ID="txtDate" CssClass="form-control"   runat="server"></asp:TextBox>--%>

    </div>
   
    <br />
</asp:Content>
