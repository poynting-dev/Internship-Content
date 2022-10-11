<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringTest.aspx.cs" Inherits="ASPNETWebApplication.CookiesTest" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test Page</title>
    <link rel="stylesheet" href="Content/bootstrap.css" />
</head>
<body>
    <form id="form1" runat="server" style="margin: .5%">

        <asp:HiddenField ID="HiddenField1" Value="1" runat="server" />
        <asp:Label ID="lblClick" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="btnClick" />

        <hr />

    </form>
</body>
</html>
