﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StronaBezAjax.aspx.cs" Inherits="P06WprowadzenieDoAJAX.StronaBezAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       

        <asp:Button ID="btnPolicz" OnClick="btnPolicz_Click"    runat="server" Text="Button" />
        
        <asp:TextBox ID="txtLiczba1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLiczba2" runat="server"></asp:TextBox>

        <asp:Label ID="lblWynik" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
