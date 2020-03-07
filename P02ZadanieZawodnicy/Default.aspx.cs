using P01AplikacjaZawodnicy.KlasyDomenowe;
using P01AplikacjaZawodnicy.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02ZadanieZawodnicy
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
  
        }

        protected void btnSzukaj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            ZawodnicyRepo zr = new ZawodnicyRepo();
            Zawodnik z = zr.PodajZawodnikow(id);
            lblWynik.Text = z.Imie + " " + z.Nazwisko;
        }
    }
}