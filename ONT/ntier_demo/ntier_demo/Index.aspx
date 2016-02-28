<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ntier_demo.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <h1>List All Employee</h1>
        

        <asp:GridView ID="dgvAllEmployee" runat="server" AllowPaging="True" OnPageIndexChanged="dgvAllEmployee_PageIndexChanged">

        </asp:GridView>
    </div>
    </form>
</body>
</html>
