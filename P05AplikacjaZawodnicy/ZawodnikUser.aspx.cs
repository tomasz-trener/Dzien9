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
            ZawodnicyRepo zr = new ZawodnicyRepo();
            Zawodnik[] zawodnicy =  zr.PodajWszystkichZawodnikow();

            Zawodnik z = zawodnicy[0];

            txtId.Text = z.Id.ToString();
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtWzrost.Text = z.Wzrost.ToString();
            txtWaga.Text = z.Waga.ToString();
            txtKraj.Text = z.Kraj;



        }
    }
}