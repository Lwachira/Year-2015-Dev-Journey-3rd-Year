<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="examNorthwind._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  

    <div class="jumbotron">
       
        <div class="container">
              <h1>Northwind</h1>
            <p class="lead">The benefits of having n-tier architecture is that all the modules having dedicated functionality will be independent of each other.</p>


        </div>
          
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Delete Shipper</h2>
            <p>
                </p>
            <p>
                <a class="btn btn-default"   href="Default.aspx">Click Me</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Add Shipper</h2>
            <p>
            </p>
            <p>
                <a class="btn btn-default"   href="Default.aspx">Click Me</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Update Shipper</h2>
            <p>
            </p>
            <p>
                <a class="btn btn-default"   href="Default.aspx">Click Me</a>
            </p>
        </div>
    </div>


     <div class="row">
        <div class="col-md-4">
            <h2>View All Shipper</h2>
            <p>
                 </p>
            <p>
                <a class="btn btn-default"   href="Views/AllShipper.aspx">Click Me</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>View Shipper</h2>
            <p>
            </p>
            <p>
                <a class="btn btn-default"   href="Views/Shipper.aspx">Click Me</a>
            </p>
        </div>

       
    </div>

</asp:Content>
