<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StronaZAjax.aspx.cs" Inherits="P06WprowadzenieDoAJAX.StronaZAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="lib/jquery-3.4.1.min.js"></script>
    <script src="JsSkrypty/MojeSkrypty.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       

        <input type="button"  id="btnPolicz" value="Policz" />

        <input type="text" id="txtLiczba1" style="width:100px" />
        <input type="text" id="txtLiczba2" style="width:100px" />

        <span id="lblWynik"></span>

    </form>
</body>
</html>
