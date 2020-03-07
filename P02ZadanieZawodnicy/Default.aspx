<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P02ZadanieZawodnicy.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnSzukaj" OnClick="btnSzukaj_Click" runat="server" Text="Button" />
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <asp:Label ID="lblWynik" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
