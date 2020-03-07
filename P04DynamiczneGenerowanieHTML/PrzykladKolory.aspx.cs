using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P04DynamiczneGenerowanieHTML
{
    public partial class PrzykladKolory : System.Web.UI.Page
    {
        public string[] Wyrazy;
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "Ala ma kota";

            Wyrazy = s.Split(' ');

            
        }
    }
}