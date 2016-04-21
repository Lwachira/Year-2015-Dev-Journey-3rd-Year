<%@ Page Title="Get Pilot Hours" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pilotHours.aspx.cs" Inherits="Aviaco_V1.pilotHours" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>For any specific pilot, the total number of hours flown on all charters.</h1>


    <div class="form-group">


          <asp:Label  Text="Pilot ID" runat="server" />
        <asp:TextBox runat="server" CssClass="form-control" ID="txtPilotID" />
        <br />

            <asp:Label Text="text" runat="server" ID="lblDisplay" />
           <br />
        <asp:Button Text="Search Pilot" runat="server" ID="btnSearch" OnClick="btnSearch_Click"/>
        </div>


  
</asp:Content>
