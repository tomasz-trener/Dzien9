<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P03ZadanieZawody.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:ListBox ID="lbZawodnicy" AutoPostBack="true" OnSelectedIndexChanged="lbZawodnicy_SelectedIndexChanged" runat="server"></asp:ListBox>
        <br />
        <asp:Label ID="lblZawody" runat="server" ForeColor="Red" Text="Label"></asp:Label>

    </form>
</body>
</html>
