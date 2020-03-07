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
    public partial class ListaZawodnikow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ZawodnicyRepo zr = new ZawodnicyRepo();
                string[] kraje = zr.PodajWszystkieKraje();

                List<string> lista = kraje.ToList();
                lista.Insert(0, "");
                kraje = lista.ToArray();

                ddlKraje.DataSource = kraje;
                ddlKraje.DataBind();
            }
          

        }

        protected void btnSzukaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepo zr = new ZawodnicyRepo();
            Zawodnik[] zawodnicy = zr.PodajZawodnikow(ddlKraje.SelectedValue);

            lbDane.DataSource = zawodnicy;
            lbDane.DataTextField = "Nazwisko";
            lbDane.DataValueField = "Id";
            lbDane.DataBind();
        }

        protected void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zaznaczonyZawodnik = lbDane.SelectedValue;

            ZawodnicyRepo zr = new ZawodnicyRepo();
            Zawodnik z= zr.PodajZawodnikow(Convert.ToInt32(zaznaczonyZawodnik));
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            txtWaga.Text = z.Waga.ToString();
            txtWzrost.Text = z.Wzrost.ToString();
        }
    }
}