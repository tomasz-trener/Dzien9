<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P04DynamiczneGenerowanieHTML.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

         <%
             int a = 5;
             string s = "ala ma kota <br>";

             for (int i = 0; i < a; i++)
             {
                 Response.Write(s);
             }

             %>


    </form>
</body>
</html>
