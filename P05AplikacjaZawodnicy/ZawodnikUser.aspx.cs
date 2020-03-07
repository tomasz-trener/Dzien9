using P05AplikacjaZawodnicy.KlasyDomenowe;
using P05AplikacjaZawodnicy.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P05AplikacjaZawodnicy
{
    public partial class ZawodnikUser : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);

            ZawodnicyRepo zr = new ZawodnicyRepo();
            Zawodnik z= zr.PodajZawodnikow(id);

            txtId.Text = z.Id.ToString();
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtWzrost.Text = z.Wzrost.ToString();
            txtWaga.Text = z.Waga.ToString();
            txtKraj.Text = z.Kraj;



        }
    }
}