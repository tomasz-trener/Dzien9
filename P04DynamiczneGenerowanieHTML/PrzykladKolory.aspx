<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrzykladKolory.aspx.cs" Inherits="P04DynamiczneGenerowanieHTML.PrzykladKolory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
      <%--  <span style="color:red">hej</span>--%>
         


<%--        <%
            for (int i = 0; i < Wyrazy.Length; i++)
            {
                if (Wyrazy[i].Length<3)
                {
                    Response.Write("<span style='color:red'>" + Wyrazy[i] + "</span>");
                }
            }

            %>  --%>  


          <%
            for (int i = 0; i < Wyrazy.Length; i++)
            {
                if (Wyrazy[i].Length<3)
                {  %> 
                  <%--<span style="color:red"><% Response.Write(Wyrazy[i]); %></span>--%>  
                    <span style="color:red"><%= Wyrazy[i] %></span>
            <%  }else if (Wyrazy[i].Length == 3)
                    { %> 
                         <span style="color:green"><%= Wyrazy[i] %></span>
                  <%  }
                          else
                          { %> 
                            <span style="color:blue"><%= Wyrazy[i] %></span>

                        <%  }
                      }

            %>  
    


    </form>
</body>
</html>
