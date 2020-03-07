<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrzykladKolory2.aspx.cs" Inherits="P04DynamiczneGenerowanieHTML.PrzykladKolory2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
        <%
            for (int i = 0; i < Wynik.Length; i++)
            { %>
               <span style="color:<%= Wynik[i][1] %>" ><%= Wynik[i][0] %></span>
        <%  }

            %>


    </form>
</body>
</html>
