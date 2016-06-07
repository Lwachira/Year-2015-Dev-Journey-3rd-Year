<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shipper.aspx.cs" Inherits="examNorthwind.Views.Shipper" EnableEventValidation="false" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h1>View Shipper</h1>

    <form role="form">
        <div class="form-group">
            <label class="control-label" for="drpShipperID">Shipper ID</label>
            <asp:DropDownList class="form-control" id="drpShipperID" runat="server" OnSelectedIndexChanged="drpShipperID_SelectedIndexChanged">
                
            </asp:DropDownList>
        </div>

        <asp:Button ID="btnSubmit"  class="btn btn-default" runat="server" OnClick="btnSubmit_Click" Text="Submit"  />
        
    </form>


    <asp:GridView ID="dgvShipper" runat="server" CssClass="table"></asp:GridView>
</asp:Content>
