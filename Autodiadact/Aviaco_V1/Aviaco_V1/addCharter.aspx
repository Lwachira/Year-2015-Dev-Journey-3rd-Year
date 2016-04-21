<%@ Page Title="Add Charter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addCharter.aspx.cs" Inherits="Aviaco_V1.addCharter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Add New Charters</h1>

    <div class="form-group">

         <asp:Label  Text="Charter Trip" runat="server" />

        <asp:TextBox CssClass="form-control"  runat="server" ID="txtTrip"  />
        <br />

         <asp:Label   ID="lblDate" runat="server" Text="Date"></asp:Label>


        <asp:TextBox runat="server" CssClass="form-control" ID="txtDate"  />


        <asp:Label  Text="Account Number" runat="server" />

        <asp:TextBox CssClass="form-control"  runat="server" ID="txtAccountNum" />
        <br />



           <asp:Label  Text="Destination" runat="server" />

        <asp:DropDownList runat="server" CssClass="form-control" ID="drpDestination">
            <asp:ListItem Text="ATL" />
            <asp:ListItem Text="BNA" />
        </asp:DropDownList>


        
        <br />
        
         <asp:Label  Text="Distance" runat="server" />

        <asp:TextBox CssClass="form-control"  runat="server" ID="txtDistance" />

        <br />


          <asp:Label  Text="Hours Flown" runat="server" />

        <asp:TextBox CssClass="form-control"  runat="server"  ID="txtHoursFlown"/>

        <br />


         <asp:Label  Text="Hours Wait" runat="server" />

        <asp:TextBox CssClass="form-control"  runat="server" ID="txtHoursWait" />

        <br />

         <asp:Label  Text="Fuel Gallons" runat="server" />
         
        <asp:TextBox CssClass="form-control"  runat="server" ID="txtFuelGallons" />

        <br />


         <asp:Label  Text="Oil Quantity" runat="server" />

        <asp:TextBox CssClass="form-control"  runat="server" ID="txtOilQuantity" />

        <br />

         <asp:Label  Text="Customer Code" runat="server" />

        <asp:TextBox CssClass="form-control"  runat="server" ID="txtCusCode" />

        <br />

     
<%--    <asp:TextBox ID="txtDate" CssClass="form-control"   runat="server"></asp:TextBox>--%>

    </div>
   
    <br />


    <asp:Button Text="Add " CssClass="btn btn-primary" ID="btAdd" OnClick="btAdd_Click" runat="server" />
</asp:Content>
