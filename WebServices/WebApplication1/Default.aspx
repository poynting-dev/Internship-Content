<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

   <head runat="server">
      <title>
         Untitled Page
      </title>
   </head>
   
   <body>
   
      <form id="form1" runat="server">
         <div>
         
            <h3>Fetch Data</h3>
            
            <br /> <br />
            
            <asp:Label ID="lblmessage" runat="server"></asp:Label>
            
            <br /> <br />
            
               
            <asp:Button ID="btnservice" runat="server" onclick="btnservice_Click"  Text="Get Data" style="width:99px" />
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         </div>
      </form>
      
   </body>
</html>