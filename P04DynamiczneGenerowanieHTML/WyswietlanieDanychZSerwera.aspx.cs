using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P04DynamiczneGenerowanieHTML
{
    public partial class WyswietlanieDanychZSerwera : System.Web.UI.Page
    {
        public string Napis;
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "ala ma kota <br>";

            Napis = s;

            //for (int i = 0; i < 5; i++)
            //{
            //    Response.Write(s);
            //}
            

        }
    }
}