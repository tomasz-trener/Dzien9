<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WyswietlanieDanychZSerwera.aspx.cs" Inherits="P04DynamiczneGenerowanieHTML.WyswietlanieDanychZSerwera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            tutaj:

            <%
                for (int i = 0; i < 5; i++)
                {
                     Response.Write(Napis);
                }
               
                %>

            koniec

        </div>
    </form>
</body>
</html>
