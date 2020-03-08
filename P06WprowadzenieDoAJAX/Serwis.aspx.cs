using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P06WprowadzenieDoAJAX
{
    public partial class Serwis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "ala ma kota";

            Response.Write(s);
        }
    }
}