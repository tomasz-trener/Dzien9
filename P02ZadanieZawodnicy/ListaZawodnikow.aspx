<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaZawodnikow.aspx.cs" Inherits="P02ZadanieZawodnicy.ListaZawodnikow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="ddlKraje" runat="server"></asp:DropDownList>
          
            <asp:ListBox ID="lbDane" AutoPostBack="true" OnSelectedIndexChanged="lbDane_SelectedIndexChanged" runat="server"></asp:ListBox>
            
            <asp:Button ID="btnSzukaj" OnClick="btnSzukaj_Click" runat="server" Text="Szukaj" />

            <br />
            <br />

            <table style="margin-top:50px">
                <tr>
                    <td>Imie</td>
                    <td><asp:TextBox ID="txtImie" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nazwisko</td>
                    <td><asp:TextBox ID="txtNazwisko" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Kraj</td>
                    <td><asp:TextBox ID="txtKraj" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Waga</td>
                    <td><asp:TextBox ID="txtWaga" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Wzrost</td>
                    <td><asp:TextBox ID="txtWzrost" runat="server"></asp:TextBox></td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
