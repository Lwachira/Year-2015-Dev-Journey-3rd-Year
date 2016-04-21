<%@ Page Title="Pilot Names" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pilotName.aspx.cs" Inherits="Aviaco_V1.pilotName" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>

        The names of all pilots
    </h1>


    <div class="form-group">


        <asp:TextBox runat="server" ID="txtDate" CssClass="form-control" />

        <asp:DropDownList runat="server" CssClass="form-control" ID="drpDate">
           
        </asp:DropDownList>

        <asp:Button Text="Search Pilots" runat="server" ID="btnDate" OnClick="btnDate_Click" />
</div>
        
</asp:Content>
