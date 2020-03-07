using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P04DynamiczneGenerowanieHTML
{
    public partial class PrzykladKolory2 : System.Web.UI.Page
    {
        public string[][] Wynik;
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "ala ma kota";
            string[] tab = s.Split(' ');

            Wynik = new string[tab.Length][];
            for (int i = 0; i < tab.Length; i++)
            {
                Wynik[i] = new string[2];

                Wynik[i][0] = tab[i];
                if (tab[i].Length < 3)
                    Wynik[i][1] = "red";
                else if (tab[i].Length == 3)
                    Wynik[i][1] = "green";
                else
                    Wynik[i][1] = "blue";
            }


        }
    }
}