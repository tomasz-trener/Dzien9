<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StronaDruga.aspx.cs" Inherits="P01Wstep.StronaDruga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnPrzycisk" 
                OnClick="btnPrzycisk_Click" 
                runat="server" Text="Button" />
          
            <asp:TextBox ID="txtPoleTekstowe" 
                runat="server"></asp:TextBox>

        </div>
    </form>
</body>
</html>
