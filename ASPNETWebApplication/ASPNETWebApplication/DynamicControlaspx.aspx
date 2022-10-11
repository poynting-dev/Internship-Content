<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicControlaspx.aspx.cs" Inherits="ASPNETWebApplication.DynamicControlaspx" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="/docs/4.0/assets/img/favicons/favicon.ico">

    <title>Signin</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/4.0/examples/sign-in/">

    <link href="https://getbootstrap.com/docs/4.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="Content/signin.css" rel="stylesheet">
  </head>

<body class="text-center">
    <form id="form1" class="form-signin" runat="server">
        <asp:Label class="h3 mb-3 font-weight-normal"  ID="Label1" runat="server" Text="">Please sign in</asp:Label>
      <%--<h1 class="h3 mb-3 font-weight-normal" id="lblemail">Please sign in</h1>--%>
        <asp:TextBox ID="inputEmail" runat="server" CssClass="form-control" placeholder="Email address" OnTextChanged="onChange" autofocus ></asp:TextBox>
        <asp:TextBox ID="inputPassword" runat="server" CssClass="form-control" placeholder="Password" OnTextChanged="onChange"></asp:TextBox>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">

        </asp:PlaceHolder>
      <div class="checkbox mb-3">
        <label>
          <input type="checkbox" value="remember-me"> Remember me
        </label>
      </div>
        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-lg btn-primary btn-block" Text="Sign-in" />
      <p class="mt-5 mb-3 text-muted">&copy; 2017-2018</p>
    </form>
  </body>
</html>
