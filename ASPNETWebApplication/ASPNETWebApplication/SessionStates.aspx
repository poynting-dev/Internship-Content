<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionStates.aspx.cs" Inherits="ASPNETWebApplication.SessionStates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1206px;
        }
    </style>
    <link rel="stylesheet" href="Content/bootstrap.css" />
</head>
<body style="margin: .5%;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            Name: 
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
        </div>
        <hr />
        <div>
            <asp:TextBox ID="txtName" Placholder="Enter your name here:" runat="server" CssClass="form-control ms-auto" Width="204px"></asp:TextBox> 
            <asp:Button ID="btnSubmit" runat="server" Text="Button" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
