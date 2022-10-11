<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="demo2.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" validate></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" validate/>
    </form>
</body>
</html>
